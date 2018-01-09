using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class SongsForPartyLogic: ISongsForPartyLogic
    {
        private static SongsForPartyRepository SPR = new SongsForPartyRepository();
        private static SongRatingRepository SRR = new SongRatingRepository();
        public void AddSongInPartyPlaylist(long partyID, string songURL, int rating)
        {
            SongsForPartyTable song = new SongsForPartyTable
            {
                partyID = partyID,
                songURL = songURL,
                rating = rating
            };
            SPR.AddSongInPartyPlaylist(song);
        }
        public SongsForPartyTable GetSongFromPartyPlaylist(long partyID, string songURL) => SPR.GetSongFromPartyPlaylist(partyID, songURL);
        public List<SongsForPartyTable> GetAllSongs(long partyID) => SPR.GetAllSongs(partyID);
        public bool RemoveSongFromPartyPlaylist(long partyID, string songURL) => SPR.RemoveSongFromPartyPlaylist(partyID, songURL);
        public SongsForPartyTable UpdateSongsForParty(SongsForPartyTable songs)
        {
            long partyID = songs.partyID;
            string songURL = songs.songURL;
            songs.rating = SRR.CalculateTotalSongRating(songs.partyID, songs.songURL);
            return SPR.UpdateSongRating(songs);

        }

    }
}
