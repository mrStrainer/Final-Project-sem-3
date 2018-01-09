using SpotifyAPI.Local;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Models;

namespace ClientChooseEm
{

    public sealed class DataStorage
    {
        private static DataStorage _instance = null;

        public PrivateProfile _profile { get; set; }
        public string CurrentSpotifyPlaylistId { get; set; }
        public long UserId { get; set; }
        public long CurrentSelectedPartyId { get; set; }
        public bool adminAtParty { get; set; }

        public SpotifyWebAPI _spotifyDS { get; set; }
        public SpotifyLocalAPI _spotifyLocalDS { get; set; }


        private DataStorage()
        {
            CurrentSpotifyPlaylistId = "";
        }

        public static DataStorage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataStorage();
                }
                return _instance;
            }
        }
    }


}
