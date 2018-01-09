using System;
using SpotifyAPI.Web;

namespace WebClientV2
{
    public partial class SeeParty : System.Web.UI.Page
    {
        private SpotifyWebAPI _spotify = new SpotifyWebAPI();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void XchngTkn()
        {
            _spotify.TokenType = "Bearer";
            _spotify.AccessToken = hfield.Value;
            _spotify.UseAuth = true;
            System.Diagnostics.Debug.WriteLine("elvielg megy" + _spotify.AccessToken);
        }

        protected void GetList(object sender, EventArgs e)
        {

        }
    }
}