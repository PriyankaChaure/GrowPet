using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Admin
{
    public class AdminVM
    {
        [Required(ErrorMessage = "First Name Require!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Require!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address Required!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Mobile No Require!")]
        [RegularExpression("^\\d{10}$", ErrorMessage = "Input 10 Digits!")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "EmailId Require!")]
        [EmailAddress(ErrorMessage = "Invalid EmailId!")]
        public string EmailId { get; set; }
       
    }
}
