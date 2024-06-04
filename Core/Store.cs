using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblStore")]
    public class Store
    {
        [Key]
        public Int64 StoreId {  get; set; }
        [Required(ErrorMessage = "Strore Name Require!")]
        public string StoreName { get; set; }
        [Required(ErrorMessage = "First Name Require!")]
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
        public bool IsActive {  get; set; }
        [ForeignKey("City")]
        public Int64 CityId { get; set; }
        public virtual City City { get; set; }
        public virtual List<Product> Products { get; set; }
        public virtual List<Cart> Carts { get; set; }
        public virtual List<StoreReview> StoreReviews { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Offer> Offers { get; set; }     

    }
}
