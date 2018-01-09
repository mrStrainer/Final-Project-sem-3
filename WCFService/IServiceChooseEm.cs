using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    [ServiceContract]
    public interface IServiceChooseEm
    {
        [OperationContract]
        void CreateUser(String firstName, String lastName, bool accountType, String zip, long currentPartyID);
    }
}
