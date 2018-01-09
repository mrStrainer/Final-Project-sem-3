using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessLogicLayer;

namespace WCFService
{
    public class LogInService : ILogInService
    {
        private static IUserLogic userLogicObj = new UserLogic();
        public bool CheckCredentials(String username, String password) => userLogicObj.CheckCredentials(username, password);
    }
}