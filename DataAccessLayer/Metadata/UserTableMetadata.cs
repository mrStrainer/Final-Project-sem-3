using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Metadata
{
    [MetadataType(typeof(UserTableMetaData))]
    public partial class UserTable
    {
        
    }
  
    public class UserTableMetaData
    {
        [DataMember]
        public long ID { get; set; }
        [DataMember]
        public string firstName { get; set; }
        [DataMember]
        public string lastName { get; set; }
        [DataMember]
        public bool accountType { get; set; }
        [DataMember]
        public int zip { get; set; }
        [DataMember]
        public Nullable<long> currentPartyID { get; set; }
    }


}
