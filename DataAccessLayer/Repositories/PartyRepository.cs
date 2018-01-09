using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class PartyRepository
    {
        public PartyTable CreateParty(PartyTable party)
        {
            using (var db = new EntitiesChooseEm())
            {
                db.PartyTables.Add(party);
                db.SaveChanges();

            }
            return party;

        }
        
        /// <summary>
        /// Get a party specified by id
        /// </summary>
        /// <param name="partyId"></param>
        /// <returns></returns>
        public PartyTable GetParty(long partyId)
        {
            PartyTable party;
            using (var db = new EntitiesChooseEm())
            {
                party = db.PartyTables.FirstOrDefault(p => p.ID == partyId);
            }
            return party;
        }

        
        /// <summary>
        /// Get user data of the party owner
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserTable GetOwner(long userId)
        {
            UserTable user;
            using (var db = new EntitiesChooseEm())
            {
                user  = db.UserTables.FirstOrDefault(u => u.ID == userId);
            }
            return user;
        }

        /// <summary>
        /// Delete a party from the database
        /// </summary>
        /// <param name="partyId"></param>
        /// <returns></returns>
        public bool RemoveParty(long partyId)
        {
            PartyTable party;
            using (var db = new EntitiesChooseEm())
            {
                party = db.PartyTables.FirstOrDefault(p => p.ID == partyId);
                if (party == null) return false;
                
                db.PartyTables.Remove(party);
                db.SaveChanges();
            }
            return true;
        }

        /// <summary>
        /// Update the party details
        /// </summary>
        /// <param name="updatedParty"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public PartyTable UpdateParty(PartyTable updatedParty)
        {
            using (var context = new EntitiesChooseEm())
            { //check for party being null?
                PartyTable party        = context.PartyTables.FirstOrDefault(p => p.ID == updatedParty.ID);
                
                party.startDate         = updatedParty.startDate;
                party.endDate           = updatedParty.endDate;
                party.locationLatitude  = updatedParty.locationLatitude;
                party.locationLongitude = updatedParty.locationLongitude;
                party.privacy           = updatedParty.privacy;
                party.Name              = updatedParty.Name;
                party.RowVersion = updatedParty.RowVersion;
                party.AvailablePlaces = updatedParty.AvailablePlaces;


                context.PartyTables.Attach(party);
                context.Entry(party).State = System.Data.Entity.EntityState.Modified;

                var num = context.SaveChanges();

                if (num != 1)
                {
                    throw new Exception("Concurrency Error");

                }
            }
            return updatedParty;
        }
        
        
        /// <summary>
        /// Get all parties of the specific user
        /// </summary>
        /// <param name="ownerId"></param>
        /// <returns></returns>
        public List<PartyTable> GetAllParties(long ownerId)
        {
            List<PartyTable> parties;
            using (var db = new EntitiesChooseEm())
            {
                parties = db.PartyTables.Where(p => p.ownerID == ownerId).ToList();
            }
            return parties;
        }

        public List<PartyTable> GetAllNotJoinedParties(long userId)
        {
            
            var parties = new List<PartyTable>();
            using (var db = new EntitiesChooseEm())
            {
                //to be change based on location and privacy
                var uap = db.PartyTables.ToList();
                foreach (var foundParties in uap)
                {
                    if (!GetSelectedNotJoined(foundParties.ID, userId)) 
                    parties.Add(foundParties);
                }
            }
            return parties;
        }

        public List<PartyTable> GetAllJoinedParties(long userId)
        {
            var parties = new List<PartyTable>();
            using (var db = new EntitiesChooseEm())
            {
                var uap = db.UsersAtParties.Where(i => i.userID == userId).ToList();
                foreach (var foundParties in uap) {
                    
                    parties.Add(GetSelectedJoined(foundParties.partyID));
                }
                
            }
            return parties;
        }

        private bool GetSelectedNotJoined(long partyId, long userId) {
            using (var db = new EntitiesChooseEm())
            {
                return db.UsersAtParties.Any(arg => arg.partyID == partyId && arg.userID == userId);
            }
        }

        //Workaround the timeout issue
        //Has to be fixed in the future
        private PartyTable GetSelectedJoined(long partyId) {
            using (var db = new EntitiesChooseEm())
            {
              return db.PartyTables.FirstOrDefault(arg => arg.ID == partyId);
            }
        }
    }
}

    


