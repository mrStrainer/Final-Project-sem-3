using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Timers;
using DataAccessLayer;

namespace WCFService
{   //Operation contracts & DataContract for IServiceCallBack
    #region
    public interface IServiceCallBack
    {
        [OperationContract(IsOneWay = true)]
        void BroadcastToClient(EventDataType eventData);
    }

    [DataContract()]
    public class EventDataType
    {
        [DataMember]
        public long ClientId { get; set; }

        [DataMember]
        public List<SongsForPartyTable> EventMessage { get; set; }
    }
    #endregion
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IServiceCallBack))]
    public interface IService
    {
        //Operation contracts for service comunication
        #region
        [OperationContract(IsOneWay = true)]
        void RegisterClient(long id);

        [OperationContract(IsOneWay = true)]
        void NotifyServer(EventDataType eventData);
        #endregion
        //Service contracts for User
        #region
        [OperationContract]
        [WebGet(UriTemplate = "CreateUser/{firstName}/{lastName}/{accountType}/{zip}/{currentPartyID}")]
        void CreateUser(String firstName, String lastName, bool accountType, int zip, long currentPartyID);

        [OperationContract]
        [WebGet(UriTemplate = "User/{ID}")]
        UserTable GetUser(long ID);

        [OperationContract]
        [WebGet]
        void AddLogInAccount(String username, String password);

        [OperationContract]
        List<UserTable> GetAllTheUsers();
        #endregion
        //Service contracts for Party
        #region
        [OperationContract]
        [WebGet]
        long CreateParty(PartyTable party);

        [OperationContract]
        [WebGet(UriTemplate = "Party/{ID}")]
        PartyTable GetPartyById(long ID);

        [OperationContract]
        [WebGet(UriTemplate = "Parties/{ID}")]
        List<PartyTable> GetAllParties(long ID);

        [OperationContract]
        [WebGet(UriTemplate = "Parties/{ID}")]
        List<PartyTable> GetAllNotJoinedParties(long ID);

        [OperationContract]
        [WebGet(UriTemplate = "Parties/{ID}")]
        List<PartyTable> GetAllJoinedParties(long ID);

        [OperationContract]
        [WebGet(UriTemplate = "GetOwner/{ID}")]
        UserTable GetOwner(long ID);

        [OperationContract]
        [WebGet(UriTemplate = "RemoveParty/{ID}")]
        bool RemoveParty(long ID);

        [OperationContract]
        [WebGet(UriTemplate = "UpdateParty/{updatedParty}")]
        PartyTable UpdateParty(PartyTable updatedParty);
        #endregion
        //Service contracts for UserAtParty
        #region
        [OperationContract]
        [WebGet]
        [FaultContract(typeof(Exception))]
        void CreateUserAtParty(UsersAtParty user, byte[] RowVersion);

        [OperationContract]
        [WebGet(UriTemplate = "User/{ID}")]
        UsersAtParty GetUserForID(long ID);

        [OperationContract]
        [WebGet(UriTemplate = "Users/{ID}")]
        List<UsersAtParty> GetAllUsers(long ID);

        [OperationContract]
        [WebGet(UriTemplate = "User/{ID}/{ID}")]
        UsersAtParty GetUserAfterFK(long partyID, long userID);

        [OperationContract]
        [WebGet(UriTemplate = "Parties/{ID}")]
        List<PartyTable> GetAllPartiesOfUser(long ID);

        [OperationContract]
        [WebGet(UriTemplate = "RemoveUser/{ID}/{ID}")]
        bool RemoveUserAtParty(long UserID, long PartyID);

        [OperationContract]
        [WebGet(UriTemplate = "UpdateUser/{updatedUser}")]
        UsersAtParty UpdateUserAtParty(UsersAtParty updatedUser);

        [OperationContract]
        bool IsAtParty(long userId, long partyId);
        #endregion
        //Service contracts for SongsForParty
        #region
        [OperationContract]
        [WebGet]
        void AddSongInPartyPlaylist(long partyID, string songURL, int rating);

        [OperationContract]
        [WebGet(UriTemplate = "Song/{ID}/{URL}")]
        SongsForPartyTable GetSongFromPartyPlaylist(long partyID, string songURL);

        [OperationContract]
        [WebGet(UriTemplate = "Song/{ID}")]
        List<SongsForPartyTable> GetAllSongs(long partyID);

        [OperationContract]
        [WebGet(UriTemplate = "RemoveSong/{ID}/{URL}")]
        bool RemoveSongFromPartyPlaylist(long partyID, string songURL);

        [OperationContract]
        [WebGet(UriTemplate = "UpdateSong/{ID}/{URL}")]
        SongsForPartyTable UpdateSongsForParty(SongsForPartyTable songs);
        #endregion
        //Service contracts for SongRating
        #region
        [OperationContract]
        [WebGet(UriTemplate = "AddRating/{rating}")]
        [FaultContract(typeof(Exception))]
        bool AddRating(SongRatingFromPartyTable rating);

        [OperationContract]
        [WebGet(UriTemplate = "Rating/{ID}/{URL}")]
        int CalculateTotalSongRating(long partyID, string songURL);

        [OperationContract]
        [WebGet]
        List<SongRatingFromPartyTable> GetAllRatings(long partyID, long userID);

        [OperationContract]
        [WebGet(UriTemplate = "RemoveRating/{ID}/{ID}/{URL}")]
        bool RemoveRating(long partyID, long userID, string songURL);

        [OperationContract]
        [WebGet(UriTemplate = "VoteSong/{updateSongRating}")]
        SongRatingFromPartyTable VoteSong(SongRatingFromPartyTable updateSongRating);
        #endregion
        //Service contractss for Friends
        #region
        [OperationContract]
        bool CreateFriendsLink(long id1, long id2);

        [OperationContract]
        List<FriendTable> GetAllFriends(long userID);

        [OperationContract]
        bool AreFriends(long firstUserId, long secondUserId);

        [OperationContract]
        bool RemoveFriend(long firstUserID, long secondUserID);

        [OperationContract]
        List<FriendTable> GetAllFriendsNotAtTheParty(long userId, long partyId);
        #endregion
    }

}
