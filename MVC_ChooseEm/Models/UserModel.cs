using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_ChooseEm.Models
{
    public class UserModel
    {

        public long ID { get; set; }
        [DisplayName("Surname")]
        [Required]
        public string firstName { get; set; }
        [DisplayName("Given Name")]
        [Required]
        public string lastName { get; set; }

        public bool accountType { get; set; }
        [DisplayName("Zip")]
        [Required]
        public int zip { get; set; }

        public long currentPartyID { get; set; }
    }
}