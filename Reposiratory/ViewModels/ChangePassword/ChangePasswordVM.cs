using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.ViewModels.ChangePassword
{
    public class ChangePasswordVM
    {
        [Required(ErrorMessage = "Old Password Required")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "New Password Required")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Confirm Password Required")]
        [Compare("NewPassword", ErrorMessage = "New Password and Confirm Password are not Same!")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
