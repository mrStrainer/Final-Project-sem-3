using DataAccessLayer;
using System;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class UserLogic : IUserLogic
    {
        private static UserRepository UR = new UserRepository();
        private static UserLoginRepository ULR = new UserLoginRepository();

        public void CreateUser(string firstName, string lastName, bool accountType, int zip, long currentPartyID)
        {
            UserTable user = new UserTable
            {
                firstName = firstName,
                lastName = lastName,
                accountType = accountType,
                zip = zip,
                currentPartyID = null
            };
            UR.CreateUser(user);
        }
        
        public long Createuser(string firstName, string lastName, bool accountType, int zip, long currentPartyID)
        {
            UserTable aux = new UserTable();
            UserTable user = new UserTable
           
            {
                firstName = firstName,
                lastName = lastName,
                accountType = accountType,
                zip = zip,
                currentPartyID = null
            };
            return UR.Createuser(user);
        }

        public long CheckCredentials(string username, string password) {
            if (!UserLoginRepository.CheckEmail(username)) {
                UserLoginTable userLoginTable = new UserLoginTable
                {
                    email = username,
                    password = password
                };

                return UserLoginRepository.CheckPassword(userLoginTable);
            }
            return -1;
        }

        public long AddLoginAccount(string username, string password)
        {
            UserLoginTable user = new UserLoginTable
            {
                email = username,
                password = password

            };
            return UserLoginRepository.AddLoginAccount(user);
        }

        public UserTable GetUserByID(long userId) => UR.GetUser(userId);

        public bool RemoveUser(long userId) => UR.RemoveUser(userId);

        public UserTable UpdateUser(long id, string firstName, string lastName, bool accountType, int zip, long currentPartyID)
        {
            UserTable user = new UserTable
            {
                ID = id,
                firstName = firstName,
                lastName = lastName,
                accountType = accountType,
                zip = zip,
                currentPartyID = null
            };
            return UR.UpdateUser(user);

        }
        
        public long RegisterUser(UserTable user, UserLoginTable userLogin) {
            if (!UserLoginRepository.CheckEmail(userLogin.email)) return -1;
            long ID = UR.Createuser(user);
            userLogin.userID = ID;
            return UserLoginRepository.AddLoginAccount(userLogin);
        }
        
        /// <summary>
        /// Gets all users from db
        /// </summary>
        /// <returns>List<UserTable></returns>
        public List<UserTable> GetAllUsers()
        {
            try
            {
                return UR.GetAllUsers();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
