using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using BusinessLogicLayer;
using DataAccessLayer;

namespace WCFService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service : IService
    {

        private static IUserLogic userLogicObj = new UserLogic();
        private static IPartyLogic partyLogicObj = new PartyLogic();
        private static IUsersAtPartyLogic userPObj = new UsersAtPartyLogic();
        private static ISongsForPartyLogic songObj = new SongsForPartyLogic();
        private static ISongRatingLogic ratingObj = new SongRatingLogic();
        private static IFriendsLogic friendObj = new FriendsLogic();
        private static Dictionary<long, IServiceCallBack> clients = new Dictionary<long, IServiceCallBack>();
        private static object locker = new object();

        //Callbacks and Server Notification
        #region
        public void RegisterClient(long clientId)
        {
            if (clientId > 0)
            {
                try
                {
                    IServiceCallBack callback =
                        OperationContext.Current.GetCallbackChannel<IServiceCallBack>();
                    lock (locker)
                    {
                        //remove the old client
                        if (clients.Keys.Contains(clientId))
                            clients.Remove(clientId);
                        clients.Add(clientId, callback);
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        public void NotifyServer(EventDataType eventData)
        {
            lock (locker)
            {
                var inactiveClients = new List<long>();
                foreach (var client in clients)
                {
                    if (client.Key != eventData.ClientId)
                    {
                        try
                        {
                            client.Value.BroadcastToClient(eventData);
                        }
                        catch (Exception ex)
                        {
                            inactiveClients.Add(client.Key);
                        }
                    }
                }

                if (inactiveClients.Count > 0)
                {
                    foreach (var client in inactiveClients)
                    {
                        clients.Remove(client);
                    }
                }
            }
        }
        #endregion
        //Service methods for User
        #region
        public void CreateUser(String firstName, String lastName, bool accountType, int zip, long currentPartyID) => userLogicObj.CreateUser(firstName, lastName, accountType, zip, currentPartyID);
        public UserTable GetUser(long ID)
        {
            try
            {
                return userLogicObj.GetUserByID(ID);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }

        public bool RemoveUser(long ID)
        {
            try
            {
                return userLogicObj.RemoveUser(ID);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }

        public void UpdateUser(long id, String firstName, String lastName, bool accountType, int zip, long currentPartyID) => userLogicObj.UpdateUser(id, firstName, lastName, accountType, zip, currentPartyID);

        public void AddLogInAccount(String username, String password) => userLogicObj.AddLoginAccount(username, password);
        public List<UserTable> GetAllTheUsers() => userLogicObj.GetAllUsers();
        #endregion
        //Service methods for Party
        #region
        public long CreateParty(PartyTable party) => partyLogicObj.CreateParty(party);
        public PartyTable GetPartyById(long ID)
        {
            try
            {

                return partyLogicObj.GetPartyById(ID);

            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }
        public UserTable GetOwner(long ID)
        {
            try
            {
                return partyLogicObj.GetOwner(ID);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }

        }
        public List<PartyTable> GetAllParties(long ID)
        {
            try
            {
                return partyLogicObj.GetAllParties(ID);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }


        }
        public List<PartyTable> GetAllNotJoinedParties(long ID)
        {
            try
            {
                return partyLogicObj.GetAllNotJoinedParties(ID);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }
        public List<PartyTable> GetAllJoinedParties(long ID)
        {
            try
            {
                return partyLogicObj.GetAllJoinedParties(ID);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }

        public bool RemoveParty(long ID)
        {
            try
            {
                return partyLogicObj.RemoveParty(ID);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }

        public PartyTable UpdateParty(PartyTable updatedParty) => partyLogicObj.UpdateParty(updatedParty);

        #endregion
        //Service methods for UserAtParty
        #region 
        public void CreateUserAtParty(UsersAtParty user, byte[] RowVersion)
        {
            try {userPObj.CreateUserAtParty(user, RowVersion); }

            catch (Exception ex)
            {
                throw new FaultException<Exception>(ex, ex.Message);
            }

        }
        public UsersAtParty GetUserForID(long ID)
        {
            try
            {
                return userPObj.GetUserForID(ID);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }
        public List<UsersAtParty> GetAllUsers(long ID)
        {
            try
            {
                return userPObj.GetAllUsers(ID);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }
        public UsersAtParty GetUserAfterFK(long partyID, long userID)
        {
            try
            {
                return userPObj.GetUserAfterFK(partyID, userID);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }

        public List<PartyTable> GetAllPartiesOfUser(long ID)
        {
            try
            {
                return userPObj.GetAllPartiesOfUser(ID);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }

        public bool RemoveUserAtParty(long UserID, long PartyID)
        {
            try
            {
                return userPObj.RemoveUserAtParty(UserID, PartyID);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }
        public UsersAtParty UpdateUserAtParty(UsersAtParty updatedUser) => userPObj.UpdateUserAtParty(updatedUser);

        public bool IsAtParty(long userId, long partyId) => userPObj.IsAtParty(userId, partyId);
        #endregion
        //Service methods for SongsForParty
        #region
        public void AddSongInPartyPlaylist(long partyID, string songURL, int rating) => songObj.AddSongInPartyPlaylist(partyID, songURL, rating);
        public SongsForPartyTable GetSongFromPartyPlaylist(long partyID, string songURL)
        {
            try
            {

                return songObj.GetSongFromPartyPlaylist(partyID, songURL);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }

        }
        public List<SongsForPartyTable> GetAllSongs(long partyID)
        {
            try
            {
                return songObj.GetAllSongs(partyID);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }
        public bool RemoveSongFromPartyPlaylist(long partyID, string songURL)
        {
            try
            {
                return songObj.RemoveSongFromPartyPlaylist(partyID, songURL);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }
        public SongsForPartyTable UpdateSongsForParty(SongsForPartyTable songs) => songObj.UpdateSongsForParty(songs);

        //Service methods for SongRating
        public bool AddRating(SongRatingFromPartyTable rating) {

            try
            {
                return ratingObj.AddSongRating(rating);
            }

            catch (Exception ex)
            {
                throw new FaultException<Exception>(ex, ex.Message);
            }

        }
        public int CalculateTotalSongRating(long partyID, string songURL)
        {
            try
            {
                return ratingObj.CalculateTotalSongRating(partyID, songURL);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }
        public List<SongRatingFromPartyTable> GetAllRatings(long partyID, long userID)
        {
            try
            {
                return ratingObj.GetAllRatings(partyID, userID);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }
        public bool RemoveRating(long partyID, long userID, string songURL)
        {
            try
            {
                return ratingObj.RemoveSong(partyID, userID, songURL);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }
        public SongRatingFromPartyTable VoteSong(SongRatingFromPartyTable updateSongRating)
        {
            try
            {
                return ratingObj.VoteSong(updateSongRating);
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }
        #endregion
        //Service methods for Friends
        #region
        public bool CreateFriendsLink(long id1, long id2) => friendObj.CreateFriendsLink(id1, id2);

        public List<FriendTable> GetAllFriends(long userID) => friendObj.GetAllUserFriends(userID);

        /// <summary>
        /// Returns tru if the two users are friends
        /// </summary>
        /// <param name="firstUserId"></param>
        /// <param name="secondUserId"></param>
        /// <returns></returns>
        public bool AreFriends(long firstUserId, long secondUserId) => friendObj.AreFriends(firstUserId, secondUserId);

        public bool RemoveFriend(long firstUserID, long secondUserID) => friendObj.RemoveFriend(firstUserID, secondUserID);
        #endregion
        public List<FriendTable> GetAllFriendsNotAtTheParty(long userId, long partyId) => friendObj.GetAllFriendsNotAtTheParty(userId, partyId);
    }



}
