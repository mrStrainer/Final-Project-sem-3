using System.Collections.Generic;
using DataAccessLayer;
using System;

namespace BusinessLogicLayer
{
    public class SongRatingLogic : ISongRatingLogic
    {
        private static SongRatingRepository SRR = new SongRatingRepository();
        public bool AddSongRating(SongRatingFromPartyTable rating)
        {
            try { return SRR.AddSongRating(rating); }
            catch (Exception ex) { throw ex; }
        }
        public int CalculateTotalSongRating(long partyID, string songURL) => SRR.CalculateTotalSongRating(partyID,songURL);
        public List<SongRatingFromPartyTable> GetAllRatings(long partyID,long userID) => SRR.GetAllRatings(partyID, userID);
        public bool RemoveSong(long partyID, long userID, string songURL) => SRR.RemoveSongRating(partyID, userID, songURL);
        public SongRatingFromPartyTable VoteSong(SongRatingFromPartyTable Updatedrating)
        {
            int voteType = Updatedrating.voteType;
            return SRR.VoteSong(Updatedrating);

        }
    }
}
