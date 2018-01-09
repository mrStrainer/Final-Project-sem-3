using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class UsersAtPartyRepository
    {
        public UsersAtParty CreateUserAtParty(UsersAtParty userAtParty, byte[] RowVersion)
        {
            PartyRepository pr = new PartyRepository();
            using (var db = new EntitiesChooseEm())
            {
                using (var dbContextTransaction = db.Database.BeginTransaction())
                {
                    var selectedParty = db.PartyTables.First(p => p.ID == userAtParty.partyID);
                    if (selectedParty.AvailablePlaces > 0)
                    {
                        db.UsersAtParties.Add(userAtParty);
                        db.SaveChanges();
                        selectedParty.AvailablePlaces -= 1;
                        selectedParty.RowVersion = RowVersion;
                    }
                    else throw new Exception("No places left, refresh the page");

                    try { pr.UpdateParty(selectedParty);
                        dbContextTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        throw ex;
                    }
                }
            }
            return userAtParty;
        }
        
        /// <summary>
        /// Gets a certain user from the usersAtParty table by id
        /// 
        /// what is this good for? todo: something with this
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UsersAtParty GetUserForID(long userId)
        {
            UsersAtParty userAtParty;
            using (var db = new EntitiesChooseEm())
            {
                userAtParty = db.UsersAtParties.FirstOrDefault(uP => uP.userID == userId);
            }
            return userAtParty;
        }
        
        /// <summary>
        /// Gets all users at a certain party specified by the party id
        /// </summary>
        /// <param name="partyId"></param>
        /// <returns></returns>
        public List<UsersAtParty> GetAllUsers(long partyId)
        {
            List<UsersAtParty> users = new List<UsersAtParty>();
            using (var db = new EntitiesChooseEm())
            {
                users = db.UsersAtParties.Where(uP => uP.partyID == partyId).ToList();
            }
            return users;
        }

        public UsersAtParty GetUserAfterFK(long partyId, long userId)
        {
            /// you always give back null, how was this even working? todo: delete/make this work
            UsersAtParty usersAtParty = null;
            using (var db = new EntitiesChooseEm())
            {
                var uap = db.UsersAtParties.Select(t => t.userID == userId && t.partyID == partyId);
            }
            return usersAtParty;
        }
        
        public UsersAtParty UpdateUserAtParty(UsersAtParty updatedUsers)
        {
            using (var context = new EntitiesChooseEm())
            { //check for user being null?
                UsersAtParty user = context.UsersAtParties.FirstOrDefault(u => u.userID == updatedUsers.userID);
                user.status = updatedUsers.status;
                user.adminPrivileges = updatedUsers.adminPrivileges;
                context.SaveChanges();
            }
            return updatedUsers;
        }
        
        public bool RemoveUserAtParty(long userId, long partyId)
        {
            using (var context = new EntitiesChooseEm())
            { // check for user being null?
                UsersAtParty user = context.UsersAtParties.FirstOrDefault(u => u.userID == userId && u.partyID == partyId);
                context.UsersAtParties.Remove(user);

                //change back the number of available spaces
                var aux = context.PartyTables.First(p => p.ID == partyId);
                aux.AvailablePlaces += 1;

                context.SaveChanges();
            }
            return true;
        }
        /// <summary>
        /// Rollback method 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="partyId"></param>
        /// <returns></returns>
        public bool RollBackUserAtParty(long userId, long partyId)
        {
            using (var context = new EntitiesChooseEm())
            { 
               
                context.UsersAtParties.Remove(context.UsersAtParties.FirstOrDefault
                    (u => u.userID == userId && u.partyID == partyId));

                context.SaveChanges();
            }
            return true;
        }


        /// <summary>
        /// Returns a lsit of parties which the user joined
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<PartyTable> GetAllPartiesOfUser(long userId) {
            var parties = new List<PartyTable>();
            var pr = new PartyRepository();
            using (var db = new EntitiesChooseEm())
            {
                var uap = db.UsersAtParties.Where(uP => uP.userID == userId);
                foreach (var item in uap)
                {
                    parties.Add(pr.GetParty(item.partyID));
                }
            }
            return parties;
        }
        
        
        /// <summary>
        /// Returns true if the selected user is at the selected party, false otherwise
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="partyId"></param>
        /// <returns></returns>
        public bool IsAtParty(long userId, long partyId)
        {
            bool isAtParty;
            using (var context = new EntitiesChooseEm())
            {
                isAtParty = context.UsersAtParties.Any(u => u.partyID == partyId && u.userID == userId);
            }
            return isAtParty;
        }

    }
}
