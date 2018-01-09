using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Metadata
{
    [MetadataType(typeof(UserAtPartyMetaData))]
    public partial class UserAtParty
    {

    }

    public class UserAtPartyMetaData
    {
        [DataMember]
        public long userID { get; set; }
        [DataMember]
        public long partyID { get; set; }
        [DataMember]
        public bool adminPrivileges { get; set; }
        [DataMember]
        public short status { get; set; }

    }
}
