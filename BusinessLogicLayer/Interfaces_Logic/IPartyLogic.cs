using System.Collections.Generic;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public interface IPartyLogic
    {
       long CreateParty(PartyTable party);

       PartyTable GetPartyById(long ID);

       List<PartyTable> GetAllParties(long ID);
       List<PartyTable> GetAllJoinedParties(long ID);
       List<PartyTable> GetAllNotJoinedParties(long ID);
        
        
       UserTable GetOwner(long ID);

       bool RemoveParty(long ID);
       PartyTable UpdateParty(PartyTable updatedParty);
    }
}
