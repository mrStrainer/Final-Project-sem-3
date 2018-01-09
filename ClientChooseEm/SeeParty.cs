using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientChooseEm.WCFService;
using SpotifyAPI.Local;
using SpotifyAPI.Local.Enums;
using SpotifyAPI.Local.Models;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using System.ComponentModel;

namespace ClientChooseEm
{
    public partial class SeeParty : Form
    {

        #region "callback services"

        public class BroadcastorCallback : WCFService.IServiceCallback
        {
            private System.Threading.SynchronizationContext syncContext = AsyncOperationManager.SynchronizationContext;

            private EventHandler _broadcastorCallBackHandler;
            public void SetHandler(EventHandler handler)
            {
                this._broadcastorCallBackHandler = handler;
            }

            public void BroadcastToClient(EventDataType eventData)
            {
                syncContext.Post(new System.Threading.SendOrPostCallback(OnBroadcast), eventData);
            }

            private void OnBroadcast(object eventData)
            {
                this._broadcastorCallBackHandler.Invoke(eventData, null);
            }
        }

        private delegate void HandleBroadcastCallback(object sender, EventArgs e);
        public void HandleBroadcast(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new HandleBroadcastCallback(HandleBroadcast), sender, e);
            }
            else
            {
                try
                {
                    var eventData = (WCFService.EventDataType)sender;
                    playlist = eventData.EventMessage.ToList();
                    _currentPlaylist.Clear();

                    if (PlaylistGridView.InvokeRequired)
                    {
                        PlaylistGridView.Invoke(new MethodInvoker(delegate { PlaylistGridView.Rows.Clear(); }));
                    }
                    else
                    {
                        PlaylistGridView.Rows.Clear();
                    }

                    playlist.ForEach(song =>
                    {
                        var index = PlaylistGridView.Rows.Add();
                        var row = PlaylistGridView.Rows[index];
                        var fullTrack = _spotify.GetTrack(song.songURL.Substring(14, song.songURL.Length - 14));

                        _currentPlaylist.Add(fullTrack.Uri);

                        row.Cells["Rating"].Value = song.rating;
                        row.Cells["Title"].Value = fullTrack.Name;
                        row.Cells["Artist"].Value = ArtistsToString(fullTrack.Artists);
                    });
                }
                catch (Exception ex)
                {
                }
            }
        }

        #endregion


        private readonly DataStorage _dataStorage = DataStorage.Instance;
        private  WCFService.ServiceClient _service;
        private List<string> _searchUriList;
        private Track _currentPlayingTrack;
        private List<string> _currentPlaylist = new List<string>();
        private SpotifyWebAPI _spotify;
        private SpotifyLocalAPI _spotifyLocal = new SpotifyLocalAPI();
        private string _partyName;
        private List<SongsForPartyTable> playlist = new List<SongsForPartyTable>();


        private void RegisterClient()
        {
            if ((this._service != null))
            {
                this._service.Abort();
                this._service = null;
            }

            BroadcastorCallback cb = new BroadcastorCallback();
            cb.SetHandler(this.HandleBroadcast);

            System.ServiceModel.InstanceContext context =
                new System.ServiceModel.InstanceContext(cb);
            this._service =
                new WCFService.ServiceClient(context, "TCPEndpoint");

            this._service.RegisterClient(_dataStorage.UserId);
        }

        ///TODO
        /// if nothings on the playlist in local spotify and you get an ad
        /// it wont start any song => needs more testing tho

        /// <summary>
        /// Initializing 
        /// Making sure the spotify authentication is working
        /// and the spotify local is connecting
        /// </summary>
        public SeeParty()
        {
            InitializeComponent();
            
            //_dataStorage.Initialize();
            this.RegisterClient();
            if (_spotify == null)
                PartyInit();

            //_usersRatingForASong.partyID = _dataStorage.CurrentSelectedPartyId;
            //_usersRatingForASong.userID = _dataStorage.UserId;
            //get the playlist
            //getSongsBtn_Click(new object(), new EventArgs());

            
        }
        
        /// <summary>
        /// Initializing the party ->
        /// Spotify authentication
        /// Getting current playlist with ratings from db
        /// Getting the party name
        /// </summary>
        private async void PartyInit()
        {
            _spotify = _dataStorage._spotifyDS;
            if (_spotify == null)
            {
                await RunSpotifyAuthentication();
                _dataStorage._spotifyDS = _spotify;
            }
                GetPlaylist();

            SpotifyLocalConnect();
            _spotifyLocal.OnTrackTimeChange += Spotify_OnTrackTimeChange;
            _spotifyLocal.OnTrackChange += UpdateSongData; 
            _partyName = _service.GetPartyById(_dataStorage.CurrentSelectedPartyId).Name;
        }
        
        /// <summary>
        /// Getting the current state of the party's playlist
        /// </summary>
        private async Task RunSpotifyAuthentication()
        {
            var webApiFactory = new WebAPIFactory(
                "http://localhost",
                8000,
                "cfbe22855aaf48518cf3009a0ff87b9e",
                Scope.UserReadPrivate | Scope.UserReadEmail | Scope.PlaylistReadPrivate | Scope.UserLibraryRead |
                Scope.UserReadPrivate | Scope.UserFollowRead | Scope.UserReadBirthdate | Scope.UserTopRead | Scope.PlaylistReadCollaborative |
                Scope.UserReadRecentlyPlayed | Scope.UserReadPlaybackState | Scope.UserModifyPlaybackState | Scope.PlaylistModifyPublic);

            try
            {
                _spotify = await webApiFactory.GetWebApi();
                _dataStorage._profile = await _spotify.GetPrivateProfileAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (_spotify == null) return;
        }
        
        /// <summary>
        /// Connecting to the local spotify
        /// if spotify is not running, opening spotify and connecting
        /// </summary>
        private void SpotifyLocalConnect()
        {
            while (true)
            {
                if (!SpotifyLocalAPI.IsSpotifyRunning())
                {
                    var startProcess = new Process
                    {
                        StartInfo =
                        {
                            FileName = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Spotify\Spotify.exe"
                        }
                    };
                    startProcess.Start();
                    // MessageBox.Show(@"Spotify exe has started!");
                    // return;
                }
                if (!SpotifyLocalAPI.IsSpotifyWebHelperRunning())
                {
                    MessageBox.Show(@"SpotifyWebHelper isn't running!");
                    return;
                }

                var successful = _spotifyLocal.Connect();
                if (successful)
                {
                //status update here mabbe
                    _spotifyLocal.ListenForEvents = true;
                }
                else
                {
                    var startProcess = new Process
                    {
                        StartInfo =
                        {
                            FileName = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Spotify\Spotify.exe"
                        }
                    };
                    startProcess.Start();
                    continue;
                }
                // SpotifyLocal.OnTrackTimeChange += _potify_OnTrackTimeChange;
                break;
            }
            
        }
        
        /// <summary>
        /// Showing the current playlist in PlaylistGridView
        /// </summary>
        private void GetPlaylist()
        {

            playlist = _service.GetAllSongs(_dataStorage.CurrentSelectedPartyId).OrderByDescending(aux => aux.rating).ToList();
            
             _currentPlaylist.Clear();
            
            if (PlaylistGridView.InvokeRequired)
            {
                PlaylistGridView.Invoke(new MethodInvoker(delegate { PlaylistGridView.Rows.Clear(); }));
            }
            else
            {
                PlaylistGridView.Rows.Clear();
            }

            playlist.ForEach(song =>
            {
                var index = PlaylistGridView.Rows.Add();
                var row = PlaylistGridView.Rows[index];
                var fullTrack = _spotify.GetTrack(song.songURL.Substring(14, song.songURL.Length - 14));
                
                _currentPlaylist.Add(fullTrack.Uri);
                
                row.Cells["Rating"].Value = song.rating;
                row.Cells["Title"].Value = fullTrack.Name;
                row.Cells["Artist"].Value = ArtistsToString(fullTrack.Artists);
            });    
        }
        


        /// <summary>
        /// Get all of the currently logged in spotify user's playlists
        /// </summary>
        private List<SimplePlaylist> GetUsersAllSpotifyPlaylist()
        {
            Paging<SimplePlaylist> playlists = _spotify.GetUserPlaylists(_dataStorage._profile.Id);
            List<SimplePlaylist> list = playlists.Items.ToList();

            while (playlists.Next != null)
            {
                playlists = _spotify.GetUserPlaylists(_dataStorage._profile.Id, 20, playlists.Offset + playlists.Limit);
                list.AddRange(playlists.Items);
            }
            return list;
        }
        
        /// <summary>
        /// Create an empty  spotify playlist with custom name
        /// on the current spotify account
        /// </summary>
        private  FullPlaylist CreatePlaylist(string name)
        {
            return _spotify.CreatePlaylist(_dataStorage._profile.Id, name);
        }
        
        /// <summary>
        /// Add spotify tracks to an existing playlist
        /// </summary>
        private void AddTrack(FullPlaylist playlist, string uri)
        {
            _spotify.AddPlaylistTrack(_dataStorage._profile.Id, playlist.Id, uri);
        }
        
        /// <summary>
        /// Checks if the user already has this playlist on spotify
        /// updates the playlist id
        /// </summary>
        private void FindSpotifyPlaylist()
        {
            var userPlaylists = GetUsersAllSpotifyPlaylist();
            
            var i = 0;
            while (_dataStorage.CurrentSpotifyPlaylistId == "" && i < userPlaylists.Count)
            {
                if (userPlaylists[i].Name.Equals(_partyName))
                {
                    _dataStorage.CurrentSpotifyPlaylistId = userPlaylists[i].Id;
                }
                i++;
            }
        }
        
        /// <summary>
        /// Create a new or fill up an existing playlist on spotify
        /// for the currently logged in user
        /// </summary>
        private string CreateOrFillSpotifyPlaylist()
        {
            FullPlaylist fullPlaylist;
            
            if (_dataStorage.CurrentSpotifyPlaylistId != "")
            {
                fullPlaylist = _spotify.GetPlaylist(_dataStorage._profile.Id, _dataStorage.CurrentSpotifyPlaylistId);
                _spotify.ReplacePlaylistTracks(_dataStorage._profile.Id, fullPlaylist.Id, _currentPlaylist);
            }
            else
            {
                fullPlaylist = CreatePlaylist(_partyName);
                _dataStorage.CurrentSpotifyPlaylistId = fullPlaylist.Id;
                _currentPlaylist.ForEach(uri => AddTrack(fullPlaylist, uri));
            }
            return fullPlaylist.Uri;
        }
        
        /// <summary>
        /// Updates the currently playing song and its details
        /// </summary>
        private async void UpdateSongData(object sender, TrackChangeEventArgs e)
        {
            _currentPlayingTrack = _spotifyLocal.GetStatus().Track; 
            advertLabel.Text = _currentPlayingTrack.IsAd() ? "ADVERT" : "";
            if (_currentPlayingTrack.IsAd()) {
                timeProgressBar.Maximum = _currentPlayingTrack.Length;
                smallAlbumPicture.Image = null;

                titleLinkLabel.Text = "";
                titleLinkLabel.Tag = "";

                artistLinkLabel.Text = "";
                artistLinkLabel.Tag = "";

                albumLinkLabel.Text = "";
                albumLinkLabel.Tag = "";

                return;
            }
            timeProgressBar.Maximum = _currentPlayingTrack.Length;

            smallAlbumPicture.Image = await _currentPlayingTrack.GetAlbumArtAsync(AlbumArtSize.Size160);

            titleLinkLabel.Text = _currentPlayingTrack.TrackResource.Name;
            titleLinkLabel.Tag = _currentPlayingTrack.TrackResource.Uri;

            artistLinkLabel.Text = _currentPlayingTrack.ArtistResource.Name;
            artistLinkLabel.Tag = _currentPlayingTrack.ArtistResource.Uri;

            albumLinkLabel.Text = _currentPlayingTrack.AlbumResource.Name;
            albumLinkLabel.Tag = _currentPlayingTrack.AlbumResource.Uri;
        }
        
        /// <summary>
        /// Starts playing the currently selected track on 
        /// the locally running spotify
        /// Updates song details via UpdateSongData()
        /// </summary>
        private async void PlayNewByUri(string uri){
            await _spotifyLocal.PlayURL(uri); 
           
            //change done so that we can use the method as an info changer
            //var track = _spotifyLocal.GetStatus().Track;
            UpdateSongData(new object(), new TrackChangeEventArgs());
        }
        
        /// <summary>
        /// Calls PlayNewByUri() for the current song play
        /// Changes resumeBtn text
        /// </summary>
        private void NewPlay(string uri)
        {
            if (_spotifyLocal.GetStatus().Track.IsAd()) return;
       
            PlayNewByUri(uri);
            ResumeBtn.Text = @"Pause";
        }
        
        /// <summary>
        /// Plays or pauses the current song
        /// updates resumeBtn accordingly
        /// </summary>
        private async void  PlayPause() {
            var isPlaying = _spotifyLocal.GetStatus().Playing;
            if (isPlaying) {
                ResumeBtn.Text = @"Play ";
                await _spotifyLocal.Pause();
            } else {
                ResumeBtn.Text = @"Pause ";
                await _spotifyLocal.Play();
            }
        }
        
        /// <summary>
        /// Start the party
        /// Starts playing the playlist with the current order 
        /// based on the rating from the votes of each user
        /// voting should be disabled after the playback has started (!) db update? isStarted? ...
        /// </summary>
        private void StartPlaylist()
        {
            FindSpotifyPlaylist();
            var uri = CreateOrFillSpotifyPlaylist();
            PlayNewByUri(uri);
        }
        
        /// <summary>
        /// Concatenating artist names for better display
        /// </summary>
        private static string ArtistsToString(List<SimpleArtist> list)
        {
            string myArtists = null;

            list.ForEach(artist => {
                if (myArtists == null) {
                    myArtists = artist.Name;
                } else {
                    myArtists += ", " + artist.Name;
                }
            });
            return myArtists;
        }
        
        /// <summary>
        /// Filling up the  List box with the current
        /// search results, and the searchUri list accordingly
        /// 
        /// On btn click, doubleclick, space or enter press
        /// </summary>
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text.Equals("")) return;
            
            SearchResultLB.Items.Clear();
            
            _searchUriList = new List<string>();
            
            var resulTracks = _spotify.SearchItems(SearchBox.Text, SearchType.Track).Tracks.Items.ToList();
            //var sList = searchItem.Tracks.Items.ToList();
            
            resulTracks.ForEach(fulltrack =>
            {
                var fulltrackArtist = ArtistsToString(fulltrack.Artists);
                
                _searchUriList.Add(fulltrack.Uri);
                
                SearchResultLB.Items.Add($"{fulltrackArtist} - {fulltrack.Name}");
            });
        }
        
        /// <summary>
        /// pressing enter in searchbox to search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBox_Keypress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            SearchBtn_Click(sender, e);
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        /// <summary>
        /// pressing space or enter on listbox to play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchResultLB_Keypress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space || e.KeyCode != Keys.Enter ) return;
            if (SearchResultLB.SelectedIndex < 0) return;
            var selectedUri = _searchUriList[SearchResultLB.SelectedIndex];
            NewPlay(selectedUri);
        }
        
        /// <summary>
        /// doubleclick on listbox to play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchResultLB_DoubleClick(object sender, EventArgs e)
        {
            if (SearchResultLB.SelectedIndex < 0 ) return;
            var selectedUri = _searchUriList[SearchResultLB.SelectedIndex];
            NewPlay(selectedUri);
        }
        
        /// <summary>
        /// Tracking the time on the currently playing song
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Spotify_OnTrackTimeChange(object sender, TrackTimeChangeEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Spotify_OnTrackTimeChange(sender, e)));
                return;
            }
            if ((_currentPlayingTrack != null) && (_spotifyLocal.GetStatus().PlayingPosition > 0))
            {
                ResumeBtn.Visible = true;
                timeLabel.Text = $@"{FormatTime(e.TrackTime)}/{FormatTime(_currentPlayingTrack.Length)}";
                if (e.TrackTime < _currentPlayingTrack.Length)
                    timeProgressBar.Value = (int)e.TrackTime;
            } else {
                timeLabel.Text = @"- / -";
                ResumeBtn.Visible = false;
                ResumeBtn.Text = @"Pause";
            }
        }
        
        /// <summary>
        /// To show the time nicely
        /// </summary>
        /// <param name="sec"></param>
        /// <returns></returns>
        private static string FormatTime(double sec)
        {
            var span = TimeSpan.FromSeconds(sec);
            string secs = span.Seconds.ToString(), mins = span.Minutes.ToString();
            if (secs.Length < 2)
                secs = "0" + secs;
            return mins + ":" + secs;
        }
        
        /// <summary>
        /// Playing the selected song from start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlaySelectedBtn_Click(object sender, EventArgs e)
        {
                SearchResultLB_DoubleClick(sender, e);
        }
        
        /// <summary>
        /// Play/pause based on the current track's status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            PlayPause();
        }

        /// <summary>
        /// Add a song to the party's playlist
        /// </summary>
        private void AddSong()
        {
            if (SearchResultLB.SelectedIndex < 0) return;

            var selectedSearchUri = _searchUriList[SearchResultLB.SelectedIndex];
            var freshPlaylist = _service.GetAllSongs(_dataStorage.CurrentSelectedPartyId).ToList();
            var isAdded = false;
            
            freshPlaylist.ForEach(song =>
            {
                if (song.songURL.Equals(selectedSearchUri))
                    isAdded = true;
            });
            
            if (isAdded) return;
            
            _service.AddSongInPartyPlaylist(_dataStorage.CurrentSelectedPartyId, selectedSearchUri, 0);
        }
        
        /// <summary>
        /// Add the song and refresh the playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSongBtn_Click(object sender, EventArgs e)
        {
            AddSong();
            GetPlaylist();
        }

        /// <summary>
        /// Remove a song from the party's playlist
        /// </summary>
        private void RemoveSong()
        {
            var index = PlaylistGridView.CurrentCell.RowIndex;
            if (index <= 0) return;
            
            _service.RemoveSongFromPartyPlaylist(_dataStorage.CurrentSelectedPartyId, _currentPlaylist[index]);
        }
        
        /// <summary>
        /// Remove song and refresh playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveSongBtn_Click(object sender, EventArgs e)
        {
            RemoveSong();
            GetPlaylist();
            this._service.NotifyServer(
               new WCFService.EventDataType()
               {
                   ClientId = _dataStorage.UserId,
                   EventMessage = playlist.ToArray()
               });
        }
        
        /// <summary>
        /// Start the party
        /// Starts playing the playlist from start in the voted order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlaylistPlayBtn_Click(object sender, EventArgs e)
        {
            StartPlaylist();
        }

        /// <summary>
        /// Updating the party's playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            GetPlaylist();
        }

        /// <summary>
        /// Show the list of people attending
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttendingBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new AttendingForm();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }
        
        /// <summary>
        /// Invite people from your friendslist to the party
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InviteBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new InviteForm();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        /// <summary>
        /// Upvoting a song on the current playlist
        /// </summary>
        /// <param name="rowIndex"></param>
        private void Upvote(int rowIndex)
        {
            var upVoteForASong = new SongRatingFromPartyTable
            {
                partyID = _dataStorage.CurrentSelectedPartyId,
                songURL = _currentPlaylist[rowIndex],
                voteType = 1,
                userID = _dataStorage.UserId 
            };
            _service.AddRating(upVoteForASong);
            GetPlaylist();

            this._service.NotifyServer(
               new WCFService.EventDataType()
               {
                   ClientId = _dataStorage.UserId,
                   EventMessage = playlist.ToArray()
               });
        }

        /// <summary>
        /// Downvoting a song on the current playlist
        /// </summary>
        /// <param name="rowIndex"></param>
        private void Downvote(int rowIndex)
        {
            var downVoteForASong = new SongRatingFromPartyTable
            {
                partyID = _dataStorage.CurrentSelectedPartyId,
                songURL = _currentPlaylist[rowIndex],
                voteType = -1,
                userID = _dataStorage.UserId 
            };
            _service.AddRating(downVoteForASong);
            
            GetPlaylist();

            this._service.NotifyServer(
               new WCFService.EventDataType()
               {
                   ClientId = _dataStorage.UserId,
                   EventMessage = playlist.ToArray()
               });
        }
        
        /// <summary>
        /// Handling Up and Down votes in the GridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlaylistGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {    // column: upvote =>1 downvote =>2
            var senderGrid = (DataGridView)sender;
            var rowIndex = e.RowIndex;
            
            if (!(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) || e.RowIndex < 0) return;
            if (e.ColumnIndex == 1)
            {
                Upvote(rowIndex);
            } if (e.ColumnIndex == 2)
            {
                Downvote(rowIndex);
            }
        }
        
        /// <summary>
        /// Back to the party choosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new Parties();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

    }
}
