using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DataAccessLayer
{
    public class UserRepository
    {
        public bool CreateUser(UserTable user)
        {
            using (var db = new EntitiesChooseEm())
            {
                //try
                //{                 //var user = new UserTable { firstName = firstName, lastName = lastName, accountType = accountType, zip = zip, currentPartyID = currentPartyID };
                    db.UserTables.Add(user);
                    db.SaveChanges();
                //}
                //catch(Exception e)
                //{
                    
                //    System.Diagnostics.Debug.WriteLine(e.ToString());
                   
                //}
            }
            return true;

        }
        public UserTable GetUser(long ID)
        {
            UserTable user = null;
            using (var db = new EntitiesChooseEm())
            {
                try
                {
                   return user = db.UserTables.First(u => u.ID == ID);
                }
                catch(Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.ToString());
                }
            }
            return user;
        }
        public UserTable UpdateUser(UserTable updatedUser)
        {
            using (var context = new EntitiesChooseEm())
            {
                UserTable user = context.UserTables.First(u => u.ID == updatedUser.ID);
                user.firstName = updatedUser.firstName;
                user.lastName = updatedUser.lastName;
                user.accountType = updatedUser.accountType;
                user.zip = updatedUser.zip;
                user.currentPartyID = updatedUser.currentPartyID;
                context.SaveChanges();
            }
            return updatedUser;
        }
        public bool RemoveUser(long ID)
        {
            UserTable user = null;
            using (var db = new EntitiesChooseEm())
            {
                user = db.UserTables.FirstOrDefault(p => p.ID == ID);
                db.UserTables.Remove(user);
                db.SaveChanges();
            }
            return true;
        }

        public List<UserTable> GetAllUsers(long ID)
        {
            List<UserTable> users = new List<UserTable>();
            using (var db = new EntitiesChooseEm())
            {
                var user = db.UserTables.Where(u => u.ID == ID);
                foreach (var item in user)
                {
                    UserTable u = new UserTable
                    {
                        ID = item.ID,
                        firstName = item.firstName,
                        lastName = item.lastName,
                        accountType = item.accountType,
                        zip = item.zip,
                        currentPartyID = item.currentPartyID
                    };
                    users.Add(u);
                }
            }
            return users;
        }

        public long Createuser(UserTable user)
        {
            UserTable aux = new UserTable();
            using (var db = new EntitiesChooseEm())
            {
                try
                {                 //var user = new UserTable { firstName = firstName, lastName = lastName, accountType = accountType, zip = zip, currentPartyID = currentPartyID };
                    db.UserTables.Add(user);
                    db.SaveChanges();
                    aux = db.UserTables.FirstOrDefault(row => row.firstName == user.firstName && row.lastName == user.lastName);
                }
                catch (Exception e)
                {

                    System.Diagnostics.Debug.WriteLine(e.ToString());

                }
            }
            return aux.ID;

        }
        /// <summary>
        /// Gets all the users from the database
        /// </summary>
        /// <returns></returns>
        public List<UserTable> GetAllUsers()
        {
            List<UserTable> users = new List<UserTable>();
            using (var db = new EntitiesChooseEm())
            {
                var user = db.UserTables.Select(u => u);
                foreach (var item in user)
                {
                    UserTable u = new UserTable
                    {
                        ID = item.ID,
                        firstName = item.firstName,
                        lastName = item.lastName,
                        accountType = item.accountType,
                        zip = item.zip,
                        currentPartyID = item.currentPartyID
                    };
                    users.Add(u);
                }
            }
            return users;
        }
    }
}
