using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core
{
    [Table("TblAdmin")]
    public class Admin
    {
        [Key]
        public  Int64 AdminId {  get; set; }
        [Required(ErrorMessage ="First Name Require!")]
        public string FirstName {  get; set; }
        [Required(ErrorMessage = "Last Name Require!")]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + "" + LastName;
            }
        }

        [Required(ErrorMessage ="Address Required!")]
        public string Address {  get; set; }
        [Required(ErrorMessage = "Mobile No Require!")]
        [RegularExpression("^\\d{10}$",ErrorMessage ="Input 10 Digits!")]
        public string MobileNo {  get; set; }
        [Required(ErrorMessage = "EmailId Require!")]
        [EmailAddress(ErrorMessage ="Invalid EmailId!")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "Password Require!")]
        [DataType(DataType.Password)]
        public string Password {  get; set; }
    }
}
