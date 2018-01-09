using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public interface ISongRatingLogic
    {
        bool AddSongRating(SongRatingFromPartyTable rating);
        int CalculateTotalSongRating(long partyID, string songURL);
        List<SongRatingFromPartyTable>GetAllRatings(long partyID, long userID);
        bool RemoveSong(long partyID, long userID, string songURL);
        SongRatingFromPartyTable VoteSong(SongRatingFromPartyTable UpdatedRating);
    }
}
