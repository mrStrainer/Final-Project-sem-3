using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public interface IFriendsLogic
    {
        bool CreateFriendsLink(long id1, long id2);
        List<FriendTable> GetAllUserFriends(long userId);
        bool AreFriends(long firstUserId, long secondUserId);
        bool RemoveFriend(long firstUserID, long secondUserID);
        List<FriendTable> GetAllFriendsNotAtTheParty(long userId, long partyId);
    }
}
