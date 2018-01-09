using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{    
    /// <summary>
    /// Methods to access the friendships registered in the database
    /// 
    /// To avoid registering duplicate friendships we make sure that
    /// the smaller id is the idOne, and the bigger one is idTwo in 
    /// each stored friendship
    /// </summary>
    public class FriendsLogic : IFriendsLogic
    {
        private static FriendsRepository _fr = new FriendsRepository();


        /// <summary>
        /// Register a friendship for the 2 specified users in the database
        /// </summary>
        /// <param name="firstUserId"></param>
        /// <param name="secondUserId"></param>
        public bool CreateFriendsLink(long firstUserId, long secondUserId)
        {
            return firstUserId < secondUserId
                ? _fr.CreateFriendsLink(firstUserId, secondUserId)
                : _fr.CreateFriendsLink(secondUserId, firstUserId);

        }
        
        /// <summary>
        /// Returns true if the selected users are friends, false otherwise
        /// </summary>
        /// <param name="firstUserId"></param>
        /// <param name="secondUserId"></param>
        /// <returns></returns>
        public bool AreFriends(long firstUserId, long secondUserId)
        {
            return firstUserId < secondUserId ? _fr.AreFriends(firstUserId, secondUserId) : _fr.AreFriends(secondUserId, firstUserId);
        }
        
        /// <summary>
        /// Returns a list of friends containing every friend of a user specified by id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<FriendTable> GetAllUserFriends(long userId)
        {
            return _fr.GetAllUserFriends(userId);
        }
        
        /// <summary>
        /// Removes a friendship from the database
        /// </summary>
        /// <param name="firstUserId"></param>
        /// <param name="secondUserId"></param>
        /// <returns></returns>
        public bool RemoveFriend(long firstUserId, long secondUserId)
        {
            return firstUserId < secondUserId ? _fr.RemoveFriendLink(firstUserId, secondUserId) : _fr.RemoveFriendLink(secondUserId, firstUserId);
        }
        
        /// <summary>
        /// Returns a list of friends with all friends of a user, who are not at the selected party
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="partyId"></param>
        /// <returns></returns>
        public List<FriendTable> GetAllFriendsNotAtTheParty(long userId, long partyId)
        {
            var allFirendsNotAtTheParty = new List<FriendTable>();
            var uapr = new UsersAtPartyLogic();
            var allUserFriends = _fr.GetAllUserFriends(userId);
            allUserFriends.ForEach(friend =>
            {
                var friendId = friend.idOne == userId ? friend.idTwo : friend.idOne;

                if (!uapr.IsAtParty(friendId, partyId))
                {
                    allFirendsNotAtTheParty.Add(friend);
                }
            });
            return allFirendsNotAtTheParty;
        }
    }

}
