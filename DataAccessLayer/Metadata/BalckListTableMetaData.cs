using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DataAccessLayer.Metadata
{
    [MetadataType(typeof(BlackListTableMetaData))]
    public partial class BalckListTable
    {

    }

    public class BlackListTableMetaData
    {
        [DataMember]
        public long partyID { get; set; }

        [DataMember]
        public string songURL { get; set; }

        [DataMember]
        public virtual PartyTable PartyTable { get; set; }
    }
}
