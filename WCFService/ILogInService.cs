using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    [ServiceContract]
    public interface ILogInService
    {
        //Service contracts for User
        [OperationContract]
        bool CheckCredentials(String username, String password);
    }
}