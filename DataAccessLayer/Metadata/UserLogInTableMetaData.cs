using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DataAccessLayer.Metadata
{

    [MetadataType(typeof(UserLoginTableMetaData))]
    public partial class UserLoginTable
    {

    }

    public class UserLoginTableMetaData
    {
        [DataMember]
        public string email { get; set; }

        [DataMember]
        public string password { get; set; }

        [DataMember]
        public long userID { get; set; }

        //[DataMember]
        //public virtual UserTable UserTable { get; set; }
    }
}
