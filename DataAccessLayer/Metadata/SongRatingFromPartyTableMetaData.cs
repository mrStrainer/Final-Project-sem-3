using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;


namespace DataAccessLayer.Metadata
{
    [MetadataType(typeof(SongRatingFromPartyTableMetaData))]
    public partial class SongRatingFromPartyTable
    {
    }

    public class SongRatingFromPartyTableMetaData
    {
        [DataMember]
        public long partyID { get; set; }

        [DataMember]
        public long userID { get; set; }

        [DataMember]
        public string songURL { get; set; }

        [DataMember]
        public int voteType { get; set; }

        //[DataMember]
        //public virtual SongsForPartyTable SongsForPartyTable { get; set; }

        //[DataMember]
        //public virtual UserTable UserTable { get; set; }
    }
}
