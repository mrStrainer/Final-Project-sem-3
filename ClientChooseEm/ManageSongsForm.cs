using SpotifyAPI.Local;
using SpotifyAPI.Local.Enums;
using SpotifyAPI.Local.Models;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientChooseEm.WCFService;
using SpotifyAPI.Web.Models;
using System.Threading;
using System.ComponentModel;
using System.Diagnostics;

namespace ClientChooseEm
{ 
    public partial class ManageSongsForm : Form
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
                //BeginInvoke(new HandleBroadcastCallback(HandleBroadcast), sender, e);
            }
            else
            {
                try
                {
                    var eventData = (WCFService.EventDataType)sender;
                    //MessageBox.Show("test");
                   getSongsBtn_Click(sender, e);
                    //if (this.txtEventMessages.Text != "")
                    //    this.txtEventMessages.Text += "\r\n";
                    //this.txtEventMessages.Text += string.Format("{0} (from {1})",
                    //    eventData.EventMessage, eventData.ClientName);
                }
                catch (Exception ex)
                {
                }
            }
        }

        #endregion



        private readonly DataStorage _dataStorage = DataStorage.Instance;
        private WCFService.ServiceClient _service;
        private List<string> _uris;
        private List<string> _existingFullTrackPlaylist;
        private List<string> _existingPlaylist;
        private SongRatingFromPartyTable _usersRatingForASong = new SongRatingFromPartyTable();
        private List<SongRatingFromPartyTable> _collectionOfVotes = new List<SongRatingFromPartyTable>();
        private Track _currentTrack;
        private string _lastTrackUri;
        private FullPlaylist _fullPlaylist;
        private SpotifyWebAPI _spotify;
        private SpotifyLocalAPI _spotifyLocal = new SpotifyLocalAPI();


        //all should work
        
        public ManageSongsForm()
        {
            //Drawing of the form
            InitializeComponent();
            this.RegisterClient();
            //if (_dataStorage.IsReady)
            //{
            //_spotify = _dataStorage.Spotify;
            //_spotifyLocal = _dataStorage.SpotifyLocal;
            //}
            //else
            //{
            //_dataStorage.Initialize();
            //_spotify = _dataStorage.Spotify;
            //_spotifyLocal = _dataStorage.SpotifyLocal;

            //}



            SpotifyLocalConnect();
            if (_spotify == null)
            {
                Task.Run(() => RunAuthentication());
                
            }
            else
            {
               
                _usersRatingForASong.partyID = _dataStorage.CurrentSelectedPartyId;
                _usersRatingForASong.userID = _dataStorage.UserId;

                _spotifyLocal.OnTrackTimeChange += _spotify_OnTrackTimeChange;
                getSongsBtn_Click(new object(), new EventArgs());
               
            }
            
        }

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
                new WCFService.ServiceClient(context, "TPCEndpoint");

            this._service.RegisterClient(_dataStorage.UserId);
        }

        private async void RunAuthentication()
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
                //_dataStorage.Spotify = _spotify;
                _dataStorage._profile = await _spotify.GetPrivateProfileAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (_spotify == null)
            {
                return;
            }
                _usersRatingForASong.partyID = _dataStorage.CurrentSelectedPartyId;
                _usersRatingForASong.userID = _dataStorage.UserId;
            
            getSongsBtn_Click(new object(), new EventArgs());
         

        }

        //Updating song details for currently playing song
        private async void UpdateSongData(Track track)
        {
            _currentTrack = track;
            advertLabel.Text = track.IsAd() ? "ADVERT" : "";
            if (track.IsAd()) {

                timeProgressBar.Maximum = track.Length;

                return;
            }

            timeProgressBar.Maximum = track.Length;

            smallAlbumPicture.Image = await track.GetAlbumArtAsync(AlbumArtSize.Size160);

            titleLinkLabel.Text = track.TrackResource.Name;
            titleLinkLabel.Tag = track.TrackResource.Uri;

            artistLinkLabel.Text = track.ArtistResource.Name;
            artistLinkLabel.Tag = track.ArtistResource.Uri;

            albumLinkLabel.Text = track.AlbumResource.Name;
            albumLinkLabel.Tag = track.AlbumResource.Uri;
        }
        
        //Start playing a song selected by URI
        //update current song details
        private async void PlayNewByUri(string uri){
            await _spotifyLocal.PlayURL(uri); 
            var track = _spotifyLocal.GetStatus().Track;
            UpdateSongData(track);
        }

//        private void PlaySelectedPlaylist(List<string> uris)
//        {
//            _spotify.ResumePlayback("", "", uris);
//        }


        //play song by uri
        //get the track we just started
        //update album artwork accordingly
        private void NewPlay(string uri) {
            PlayNewByUri(uri);
            resumeBtn.Text = @"Pause";
            //currentUri = uri;
        }
        
        //Resume/Pause for the play button
        private  void PlayPause() {
            var isPlaying = _spotifyLocal.GetStatus().Playing;
            if (isPlaying) {
                resumeBtn.Text = @"Play ";
                 _spotifyLocal.Pause();
            } else {
                resumeBtn.Text = @"Pause ";
                 _spotifyLocal.Play();
            }
        }
        
        private void DeselectListIterator(int listNumber)
        {
            switch (listNumber)
            {
                case 1:
                    getSongsResultLB.ClearSelected();
                    break;
                case 2:
                    searchResultLB.ClearSelected();
                    break;
            }
        }
        //fill in resultbox with search results
        //TODO 
        //input validation for search
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchBox.Text.Equals("")) return;
            _uris = new List<string>();
            string myArtists;
            
            var searchItem = _spotify.SearchItems(searchBox.Text, SearchType.Track);
            searchResultLB.Items.Clear();
            var sList = searchItem.Tracks.Items.ToList();
            sList.ForEach(fulltrack => {

                var list = fulltrack.Artists;
                myArtists = null;

                list.ForEach(artist => {
                    if (myArtists == null) {
                        myArtists = artist.Name;
                    } else {
                        myArtists += ", " + artist.Name;
                    }
                });
                _uris.Add(fulltrack.Uri);
                searchResultLB.Items.Add($"{myArtists} - {fulltrack.Name}");
            });
        }
        
        //pressing enter in the searchbox 
        private void searchBox_Keypress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
                searchBtn_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
        }
        
        //space / enter on the result list to play
        private void searchResultLB_Keypress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space && e.KeyCode != Keys.Enter || _spotifyLocal.GetStatus().Track.IsAd()) return;
            if (searchResultLB.SelectedIndex < 0) return;
            var selectedUri = _uris[searchResultLB.SelectedIndex];
            _lastTrackUri = selectedUri;
            NewPlay(selectedUri);
            DeselectListIterator(1);
        }
        
        //double click on the result list to play
        private void searchResultLB_DoubleClick(object sender, EventArgs e)
        {
            if (searchResultLB.SelectedIndex < 0 || _spotifyLocal.GetStatus().Track.IsAd()) return;
            var selectedUri = _uris[searchResultLB.SelectedIndex];
            _lastTrackUri = selectedUri;
            NewPlay(selectedUri);
            DeselectListIterator(1);
        }
        

        //play/pause
        private void resumeBtn_Click(object sender, EventArgs e)
        {
            if (!_spotifyLocal.GetStatus().PlayEnabled || _spotifyLocal.GetStatus().Track.IsAd()) return;
            PlayPause();
        }

        private void _spotify_OnTrackTimeChange(object sender, TrackTimeChangeEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => _spotify_OnTrackTimeChange(sender, e)));
                return;
            }
            if ((_currentTrack != null) && (_spotifyLocal.GetStatus().PlayingPosition > 0))
            {
                resumeBtn.Visible = true;
                timeLabel.Text = $@"{FormatTime(e.TrackTime)}/{FormatTime(_currentTrack.Length)}";
                if (e.TrackTime < _currentTrack.Length)
                    timeProgressBar.Value = (int)e.TrackTime;
                
                if (Math.Abs(e.TrackTime - (_currentTrack.Length - 1.0)) < 0.1)
                {
//                    Predicate<string> uriFinder = s => s == _spotify.GetPlayingTrack().Item.Uri;
//                    System.Diagnostics.Debug.WriteLine(" " +_spotify.GetPlayingTrack().Item.Uri);
//                    var index = _existingFullTrackPlaylist.FindIndex(uriFinder);
//                    System.Diagnostics.Debug.WriteLine(" " +index);
//                    if (_existingFullTrackPlaylist.Count < index+1)
//                    {
//                        System.Diagnostics.Debug.WriteLine(" " +_spotify.GetPlayingTrack().Item.Uri);
//                        System.Diagnostics.Debug.WriteLine(" " +index);
//                        //PlayNewByUri(_existingFullTrackPlaylist[index+1]);
//                    }
                }
            } else {
                timeLabel.Text = @"- / -";
                resumeBtn.Visible = false;
                resumeBtn.Text = @"Pause";
            }
        }
        

        private static string FormatTime(double sec)
        {
            var span = TimeSpan.FromSeconds(sec);
            string secs = span.Seconds.ToString(), mins = span.Minutes.ToString();
            if (secs.Length < 2)
                secs = "0" + secs;
            return mins + ":" + secs;
        }

        //play selected from one of the lists if something is selected
        private void playSelectedBtn_Click(object sender, EventArgs e)
        {
            if (searchResultLB.SelectedIndex >= 0)
            {
                searchResultLB_DoubleClick(sender, e);
            }
            else getSongsResultLB_DoubleClick(sender, e);
        }

        private void getSongsBtn_Click(object sender, EventArgs e)
        {
            var playlist = _service.GetAllSongs(_dataStorage.CurrentSelectedPartyId).OrderByDescending(aux => aux.rating).ToList();
            var userVotes = _service.GetAllRatings(_dataStorage.CurrentSelectedPartyId, _dataStorage.UserId).ToList();
            
            RefreshSpotifyPlaylist(playlist);

            if (getSongsResultLB.InvokeRequired)
            {
                getSongsResultLB.Invoke(new MethodInvoker(delegate { getSongsResultLB.Items.Clear(); }));
            }
            else {
                getSongsResultLB.Items.Clear();
            }

            
            _existingPlaylist = new List<string>();
            _existingFullTrackPlaylist = new List<string>();
            _collectionOfVotes = new List<SongRatingFromPartyTable>();
           // _existingFullList = new List<WCFService.SongsForPartyTable>();

            userVotes.ForEach(vote =>
            {
                SongRatingFromPartyTable songRating = new SongRatingFromPartyTable
                {
                    partyID = vote.partyID,
                    songURL = vote.songURL,
                    voteType = vote.voteType,
                    userID = vote.userID
                };
                _collectionOfVotes.Add(songRating);
            }
            );

            playlist.ForEach(song =>
            {
                //addTrack(newPlaylist,song.songURL);
                
                string myArtists = null;
                SongsForPartyTable sp = new SongsForPartyTable
                {
                    partyID = song.partyID,
                    songURL = song.songURL,
                    rating = song.rating
                };
                _existingFullTrackPlaylist.Add(sp.songURL);
               // _existingFullList.Add(sp);
                var fullTrack = _spotify.GetTrack(song.songURL.Substring(14, song.songURL.Length - 14));
                
                var list = fullTrack.Artists;
                list.ForEach(artist => {
                    if (myArtists == null) {
                        myArtists = artist.Name;
                    } else {
                        myArtists += ", " + artist.Name;
                    }
                });
                _existingPlaylist.Add(fullTrack.Uri);
                if (getSongsResultLB.InvokeRequired)
                {
                    getSongsResultLB.Invoke(new MethodInvoker(delegate { getSongsResultLB.Items.Add($"{fullTrack.Name } : { myArtists}"); }));
                }
                else
                {
                    getSongsResultLB.Items.Add($"{fullTrack.Name } : { myArtists}");
                }
                
            });
            
            
        }

        private void RefreshSpotifyPlaylist(List<SongsForPartyTable> songsForPartyTable)
        {
            var partyName = _service.GetPartyById(_dataStorage.CurrentSelectedPartyId).Name;
            var playlists = GetPlaylists();
            var uris = new List<string>();
            songsForPartyTable.ForEach(track =>
            {
                uris.Add(track.songURL);
            });
                
            
            var foundid = "";
            var i = 0;
            
            while (foundid == "" && i < playlists.Count)
            {
                if (playlists[i].Name.Equals(partyName))
                {
                    foundid = playlists[i].Id;
                }
                i++;
            }
            if (foundid != "")
            {
               _fullPlaylist = _spotify.GetPlaylist(_dataStorage._profile.Id, foundid);
                _spotify.ReplacePlaylistTracks(_dataStorage._profile.Id, _fullPlaylist.Id, uris);
            }
            else
            {
                _fullPlaylist = CreatePlaylist(partyName);
                
                var playlist = _service.GetAllSongs(_dataStorage.CurrentSelectedPartyId).OrderByDescending(aux => aux.rating).ToList();
                playlist.ForEach(track =>
                {
                    AddTrack(_fullPlaylist, track.songURL);
                });
            }
            //PlayNewByUri(_fullPlaylist.Uri); --> playlist starts playing in order
            //_currentTrack.TrackResource.Uri;
            //PlayNewByUri(_fullPlaylist.Uri);
            //PlaySelectedPlaylist(uris);
            //_spotifyLocal.PlayURL(uris[1], $"uri:{uris[2]}");
        }

        //all of the users playlists
        private  List<SimplePlaylist> GetPlaylists()
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
        private  FullPlaylist CreatePlaylist(string name)
        {
            return _spotify.CreatePlaylist(_dataStorage._profile.Id, name);
        }

        private void AddTrack(FullPlaylist playlist, string uri)
        {
            _spotify.AddPlaylistTrack(_dataStorage._profile.Id, playlist.Id, uri);
        }
        
        
        
        
        
        
        
        private void UpdatePlaylistForParty(object sender, EventArgs e) {

            new Thread(() =>
            {
                getSongsBtn_Click(sender, e);
            }).Start();
            
            //_collectionOfVotes = new List<WCFService.SongRatingFromPartyTable>();
            //var userVotes = _service.GetAllRatings(_dataStorage.CurrentSelectedPartyId, _dataStorage.UserId).ToList();
            //userVotes.ForEach(vote =>
            //{
            //    WCFService.SongRatingFromPartyTable songRating = new WCFService.SongRatingFromPartyTable
            //    {
            //        partyID = vote.partyID,
            //        songURL = vote.songURL,
            //        voteType = vote.voteType,
            //        userID = vote.userID
            //    };
            //    _collectionOfVotes.Add(songRating);
            //}
            //);
            OverallRatingLbl.Text = @"Overall Rating of this song is: " + _service.GetSongFromPartyPlaylist
                (_usersRatingForASong.partyID, _usersRatingForASong.songURL).rating;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var allSongs = _service.GetAllSongs(_dataStorage.CurrentSelectedPartyId).ToList();
            var isAdded = false;
            allSongs.ForEach(track =>
            {
                if (track.songURL.Equals(_lastTrackUri))
                {
                    isAdded = true;
                }
                        
            });
            if (isAdded) return;
            
            if (_currentTrack != null)
            {
                _service.AddSongInPartyPlaylist(_dataStorage.CurrentSelectedPartyId, _lastTrackUri, 0);
                getSongsBtn_Click(sender, e);
            }
            else if (searchResultLB.SelectedIndex >= 0) {
                _service.AddSongInPartyPlaylist(_dataStorage.CurrentSelectedPartyId, _uris[searchResultLB.SelectedIndex], 0);
                getSongsBtn_Click(sender, e);
            }
                
        }

        private void getSongsResultLB_DoubleClick(object sender, EventArgs e)
        {
            if (getSongsResultLB.SelectedIndex < 0 || _spotifyLocal.GetStatus().Track.IsAd()) return;
            var selectedUri = _existingPlaylist[getSongsResultLB.SelectedIndex];
            _lastTrackUri = selectedUri;
            NewPlay(selectedUri);
            DeselectListIterator(2);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new Parties();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (getSongsResultLB.SelectedIndex < 0) return;
            var selectedUri = _existingFullTrackPlaylist[getSongsResultLB.SelectedIndex];

            //System.Diagnostics.Debug.WriteLine(partyID + " " + selectedUri);
            _service.RemoveSongFromPartyPlaylist(_dataStorage.CurrentSelectedPartyId, selectedUri);
            getSongsBtn_Click(sender, e);
        }

        
        private void getSongsResultLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (getSongsResultLB.SelectedIndex == -1) return;

            DeselectListIterator(2);

            var found = false;

            VoteSongNameLbl.Text = getSongsResultLB.Items[getSongsResultLB.SelectedIndex].ToString();
            foreach (var aux in _collectionOfVotes.ToList()) {
                if (aux.songURL.Equals(_existingFullTrackPlaylist[getSongsResultLB.SelectedIndex])) {
                    _usersRatingForASong = new SongRatingFromPartyTable
                    {
                       partyID = aux.partyID,
                       songURL = aux.songURL,
                       voteType = aux.voteType,
                       userID = aux.userID
                    };
                    found = true;
                    break;
                }
               
            }
            if (!found)
            {
                _usersRatingForASong = new SongRatingFromPartyTable
                {
                    partyID = _dataStorage.CurrentSelectedPartyId,
                    songURL = _existingFullTrackPlaylist[getSongsResultLB.SelectedIndex],
                    voteType = 0,
                    userID = _dataStorage.UserId
                };
                _collectionOfVotes.Add(_usersRatingForASong);
            }
            OverallRatingLbl.Text = @"Overall Rating of this song is: " + _service.GetSongFromPartyPlaylist
                (_usersRatingForASong.partyID, _usersRatingForASong.songURL).rating;
        }

        private void UpvoteBtn_Click(object sender, EventArgs e)
        {
            _usersRatingForASong.voteType += 1;
            _service.AddRating(_usersRatingForASong);
            this._service.NotifyServer(
               new WCFService.EventDataType()
               {
                   ClientId = _dataStorage.UserId,
                   EventMessage = null
               });
            UpdatePlaylistForParty(sender, e);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            _usersRatingForASong.voteType = 0;
            _service.AddRating(_usersRatingForASong);
            
            UpdatePlaylistForParty(sender, e);

            this._service.NotifyServer(
                new WCFService.EventDataType()
                {
                    ClientId = _dataStorage.UserId,
                    EventMessage = null
                });
        }

        private void DownvoteBtn_Click(object sender, EventArgs e)
        {
            _usersRatingForASong.voteType -= 1;
            _service.AddRating(_usersRatingForASong);
           
            UpdatePlaylistForParty(sender, e);

            this._service.NotifyServer(
               new WCFService.EventDataType()
               {
                   ClientId = _dataStorage.UserId,
                   EventMessage = null
               });
        }

        private void searchResultLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchResultLB.SelectedIndex != -1) DeselectListIterator(1);
        }
    }
}

