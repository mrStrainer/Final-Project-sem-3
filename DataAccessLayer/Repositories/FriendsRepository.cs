using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class FriendsRepository
    {
        /// <summary>
        /// Register a friendship in db if 
        /// </summary>
        /// <param name="firstUserId"></param>
        /// <param name="secondUserId"></param>
        /// <returns></returns>
        public bool CreateFriendsLink(long firstUserId, long secondUserId)
        {
            if (AreFriends(firstUserId, secondUserId)) return false;
            
            using (var db = new EntitiesChooseEm())
            {
                var friendsLink = new FriendTable
                {
                    idOne = firstUserId,
                    idTwo = secondUserId
                };
                db.FriendTables.Add(friendsLink);
                db.SaveChanges();
            }
            return true;
        }

        /// <summary>
        /// True if the two users are friends, false otherwise
        /// </summary>
        /// <param name="firstUserId"></param>
        /// <param name="secondUserId"></param>
        /// <returns></returns>
        public bool AreFriends(long firstUserId, long secondUserId) 
        {
            bool areFriends;
            using (var db = new EntitiesChooseEm())
            {
                 areFriends = db.FriendTables.Any(f => f.idOne == firstUserId && f.idTwo == secondUserId);
            }
            return areFriends;
        }

        /// <summary>
        /// Get every friend of a user specified by id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<FriendTable> GetAllUserFriends(long userId)
        {
            List<FriendTable> allFriends;
            using (var db = new EntitiesChooseEm())
            {
                 allFriends = db.FriendTables.Where(uP => uP.idOne == userId || uP.idTwo == userId).ToList();
            }
            return allFriends;
        }

        /// <summary>
        /// Remove a friendship, 2 user ids required
        /// </summary>
        /// <param name="firstUserId"></param>
        /// <param name="secondUserId"></param>
        /// <returns></returns>
        public bool RemoveFriendLink(long firstUserId, long secondUserId)
        {
            using (var context = new EntitiesChooseEm())
            {
                var  friendLink = context.FriendTables.FirstOrDefault(u => u.idOne == firstUserId && u.idTwo == secondUserId);
                
                if (friendLink == null) return false;
                
                context.FriendTables.Remove(friendLink);
                context.SaveChanges();
            }
            return true;
        }
    }
}
