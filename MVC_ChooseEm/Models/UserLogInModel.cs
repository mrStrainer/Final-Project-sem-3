using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_ChooseEm.Models
{
    public class UserLogInModel
    {

        [Required(ErrorMessage = "This field is mandatory!")]
        [DisplayName("E-mail")]
        public string email { get; set; }
        [Required(ErrorMessage = "This field is mandatory!")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password required to be {2} to {0} symbols long", MinimumLength = 3)]
        [DisplayName("Password")]
        public string password { get; set; }

        public long userID { get; set; }
        [Key]
        public string LogInErrorMessage { get; set; }
    }
}