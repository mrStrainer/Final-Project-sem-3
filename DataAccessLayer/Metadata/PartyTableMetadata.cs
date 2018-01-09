using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DataAccessLayer.Metadata
{
    [MetadataType(typeof(PartyTableMetaData))]
    public partial class PartyTable
    {

    }

    public class PartyTableMetaData
    {
        [DataMember]
        public long ID { get; set; }
        [DataMember]
        public long ownerID { get; set; }
        [DataMember]
        public System.DateTime startDate { get; set; }
        [DataMember]
        public System.DateTime endDate { get; set; }
        [DataMember]
        public Nullable<double> locationLatitude { get; set; }
        [DataMember]
        public Nullable<double> locationLongitude { get; set; }
        [DataMember]
        public bool privacy { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public byte[] RowVersion { get; set; }
        [DataMember]
        public short AvailablePlaces { get; set; }

    }
}
