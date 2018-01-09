using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Metadata
{
    [DataContract]
    [MetadataType(typeof(FriendTableMetaData))]
    public partial class FriendTable
    {

    }

    public class FriendTableMetaData
    {
        [DataMember]
        public long ID { get; set; }
        [DataMember]
        public long idOne { get; set; }
        [DataMember]
        public long idTwo { get; set; }
    }
}
