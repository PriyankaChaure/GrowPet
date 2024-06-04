using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Store1
{
    public  class StoreAddVM
    {
      
        [Required(ErrorMessage = "Strore Name Require!")]
        public string StoreName { get; set; }
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
        [Required(ErrorMessage = "Password Require!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "IsActive Require!")]
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "City Require!")]
        public Int64 CityId { get; set; }
        [Required(ErrorMessage = "State Require!")]
        public Int64 StateId {  get; set; }
        [Required(ErrorMessage = "Country Require!")]
        public Int64 CountryId { get; set; }    
    }
}
