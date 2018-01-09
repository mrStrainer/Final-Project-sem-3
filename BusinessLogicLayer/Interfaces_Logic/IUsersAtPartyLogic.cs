using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public interface IUsersAtPartyLogic
    {
        UsersAtParty CreateUserAtParty(UsersAtParty user, byte[] RowVersion);
        UsersAtParty GetUserForID(long userId);
        List<UsersAtParty> GetAllUsers(long partyId);
        UsersAtParty GetUserAfterFK(long partyId, long userId);
        bool RemoveUserAtParty(long userId,long partyId);
        UsersAtParty UpdateUserAtParty(UsersAtParty updatedUser);
        List<PartyTable> GetAllPartiesOfUser(long userId);
        bool IsAtParty(long userId, long partyId);
    }
}
