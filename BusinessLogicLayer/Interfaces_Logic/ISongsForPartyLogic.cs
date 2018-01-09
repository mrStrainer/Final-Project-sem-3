using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public interface ISongsForPartyLogic
    {
        void AddSongInPartyPlaylist(long partyID, string songURL, int rating);

        SongsForPartyTable GetSongFromPartyPlaylist(long partyID, string songURL);

        List<SongsForPartyTable> GetAllSongs(long partyID);

        bool RemoveSongFromPartyPlaylist(long partyID, string songURL);

        SongsForPartyTable UpdateSongsForParty(SongsForPartyTable songs);

    }
}
