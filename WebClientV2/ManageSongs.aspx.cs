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
using SpotifyAPI.Web.Models;
using System.Threading;
using System.ComponentModel;
using System.Diagnostics;
using WebClientV2.WCFLogin;
using WebClientV2.WCFService;

namespace WebClientV2
{
    public partial class ManageSongs : System.Web.UI.Page
    {

        private WCFService.ServiceClient _service;
        private List<string> _uris;
        private List<string> _existingFullTrackPlaylist;
        private List<string> _existingPlaylist;
        private WCFLogin.SongRatingFromPartyTable _usersRatingForASong = new WCFLogin.SongRatingFromPartyTable();
        private List<WCFLogin.SongRatingFromPartyTable> _collectionOfVotes = new List<WCFLogin.SongRatingFromPartyTable>();
        private Track _currentTrack;
        private string _lastTrackUri;
        private FullPlaylist _fullPlaylist;
        private SpotifyWebAPI _spotify;
        private SpotifyLocalAPI _spotifyLocal = new SpotifyLocalAPI();


        public class BroadcastorCallback
        {
           
        }


       
        protected void Page_Load(object sender, EventArgs e)
        {
            this.RegisterClient();
        }

        private void RegisterClient()
        {
            if ((this._service != null))
            {
                this._service.Abort();
                this._service = null;
            }

            BroadcastorCallback cb = new BroadcastorCallback();

            System.ServiceModel.InstanceContext context =
                new System.ServiceModel.InstanceContext(cb);
            this._service =
                new WCFService.ServiceClient(context, "NetTcpBinding_IService");

            this._service.RegisterClient(Convert.ToInt64(Session["id"]));
        }
    }

}