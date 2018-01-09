using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DataAccessLayer.Metadata
{
    [MetadataType(typeof(ZipTableMetaData))]
    public partial class ZipTable
    {


    }

    public class ZipTableMetaData
    {
        [DataMember]
        public int zip { get; set; }

        [DataMember]
        public string city { get; set; }
    }
}
