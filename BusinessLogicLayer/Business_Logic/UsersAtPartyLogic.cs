using System.Collections.Generic;
using DataAccessLayer;
using System;

namespace BusinessLogicLayer
{
    public class UsersAtPartyLogic : IUsersAtPartyLogic
    {
        private static UsersAtPartyRepository _upr = new UsersAtPartyRepository();

        public UsersAtParty CreateUserAtParty(UsersAtParty user, byte[] RowVersion)
        {
            try
            {
                return _upr.CreateUserAtParty(user, RowVersion);
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public UsersAtParty GetUserForID(long userId) => _upr.GetUserForID(userId);
        public List<UsersAtParty> GetAllUsers(long partyId) => _upr.GetAllUsers(partyId);
        public UsersAtParty GetUserAfterFK(long partyId, long userId) => _upr.GetUserAfterFK(partyId, userId);
        public bool RemoveUserAtParty(long userId, long partyId) => _upr.RemoveUserAtParty(userId, partyId);
        public UsersAtParty UpdateUserAtParty(UsersAtParty updatedUser)
        {
            /// this doesnt do anything TODO:fix this thing
            
            long userID          = updatedUser.userID;
            long partyID         = updatedUser.partyID;
            bool adminPrivileges = updatedUser.adminPrivileges;
            short status         = updatedUser.status;
            
            return _upr.UpdateUserAtParty(updatedUser);
        }
        public List<PartyTable> GetAllPartiesOfUser(long userId) => _upr.GetAllPartiesOfUser(userId);
        public bool IsAtParty(long userId, long partyId) => _upr.IsAtParty(userId, partyId);

    }
}
