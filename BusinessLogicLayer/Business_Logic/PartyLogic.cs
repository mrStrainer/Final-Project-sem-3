using System.Collections.Generic;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class PartyLogic : IPartyLogic
    {
        private static UsersAtPartyRepository _upr = new UsersAtPartyRepository();
        private static PartyRepository _pr = new PartyRepository();
        
        public long CreateParty(PartyTable party)
        {
            var dbParty =  _pr.CreateParty(party);
            UsersAtParty usersAtParty = new UsersAtParty
            {
                partyID = dbParty.ID,
                userID = party.ownerID,
                adminPrivileges = true,
                status = 1
            };
            _upr.CreateUserAtParty(usersAtParty, dbParty.RowVersion);
            return dbParty.ID;
        }

        public PartyTable GetPartyById(long partyId) => _pr.GetParty(partyId);

        public List<PartyTable> GetAllParties(long ownerId) => _pr.GetAllParties(ownerId);

        public List<PartyTable> GetAllJoinedParties(long userId) => _pr.GetAllJoinedParties(userId);
        
        public List<PartyTable> GetAllNotJoinedParties(long userId) => _pr.GetAllNotJoinedParties(userId);
        
        public UserTable GetOwner(long userId) => _pr.GetOwner(userId);

        public bool RemoveParty(long partyId) => _pr.RemoveParty(partyId);

        public PartyTable UpdateParty(PartyTable updatedParty) => _pr.UpdateParty(updatedParty);

    }
}
