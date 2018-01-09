using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    [ServiceContract]
    public interface ILogIn
    {
        //Service contracts for User
        [OperationContract]
        long CheckCredentials(String username, String password);

        [OperationContract]
        long RegisterUser(UserTable user, UserLoginTable userLogin);
    }
}
