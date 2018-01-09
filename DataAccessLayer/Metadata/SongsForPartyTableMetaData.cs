using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DataAccessLayer.Metadata
{
    [MetadataType(typeof(SongsForPartyTableMetaData))]
    public partial class SongsForPartyTable
    {

    }

    public class SongsForPartyTableMetaData
    {

        [DataMember]
        public long partyID { get; set; }

        [DataMember]
        public string songURL { get; set; }

        [DataMember]
        public int rating { get; set; }

        [DataMember]
        public byte[] RowVersion { get; set; }


        //[DataMember]
        //public virtual PartyTable PartyTable { get; set; }

    }
}
