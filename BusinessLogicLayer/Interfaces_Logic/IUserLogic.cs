using System;
using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public interface IUserLogic
    {
        long CheckCredentials(string username, string password);
        void CreateUser(string firstName, string lastName, bool accountType, int zip, long currentPartyID);
        UserTable GetUserByID(long ID);
        bool RemoveUser(long ID);
        UserTable UpdateUser(long id, string firstName, string lastName, bool accountType, int zip, long currentPartyID);
        long AddLoginAccount(string username, string password);
        long RegisterUser(UserTable user, UserLoginTable userLogin);
        List<UserTable> GetAllUsers();
    }
}
