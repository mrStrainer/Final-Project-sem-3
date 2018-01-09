using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLogicLayer;
using DataAccessLayer;

namespace WCFService
{
    public class LogIn : ILogIn
    {
        private static IUserLogic userLogicObj = new UserLogic();
        public long CheckCredentials(String username, String password) => userLogicObj.CheckCredentials(username, password);

        public long RegisterUser(UserTable user, UserLoginTable userLogin) => userLogicObj.RegisterUser(user, userLogin);
    }
}
