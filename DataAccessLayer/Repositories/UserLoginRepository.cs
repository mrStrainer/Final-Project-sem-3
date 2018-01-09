using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserLoginRepository
    {
        public static long AddLoginAccount(UserLoginTable userLogin)
        {
            
            var hash = SecurePasswordHasher.Hash(userLogin.password);
            userLogin.password = hash;
            System.Diagnostics.Debug.WriteLine(" addloginaccount: "+hash +" - "+userLogin.password);
            using (var db = new EntitiesChooseEm())
            {
                db.UserLoginTables.Add(userLogin);
                db.SaveChanges();
            }
            return userLogin.userID;
        }

        public static bool CheckEmail(string email)
        {
            using (var db = new EntitiesChooseEm())
                return !db.UserLoginTables.Any(o => o.email == email);
        }

        public static long CheckPassword(UserLoginTable userLogin)
        {
            using (var db = new EntitiesChooseEm())
            {
                //var hash = SecurePasswordHasher.Hash(userLogin.password);
                //userLogin.password = hash;
                //System.Diagnostics.Debug.WriteLine(" Checkpassword: " + hash + " - " + userLogin.password);
                UserLoginTable aux = db.UserLoginTables.First(o => o.email == userLogin.email);
                if (SecurePasswordHasher.Verify(userLogin.password, aux.password)) return aux.userID;
                return -1;
            }
        }

    }
}