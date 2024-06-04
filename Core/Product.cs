using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblProduct")]
    public class Product
    {
        [Key]
        public Int64 ProductId { get; set; }
        [Required(ErrorMessage = "Product Type Require!")]
        public int ProductType {  get; set; }
        [Required(ErrorMessage = "Product Price Require!")]
        public decimal ProductPrice { get; set; }
        
        [ForeignKey("Store")]
        public Int64 StoreId { get; set; }
        public virtual Store Store { get; set; }
        public virtual List<PetProduct> PetProducts { get; set; }
        public virtual List<Pet> Pets { get; set; }
        public virtual List<ProductReview> ProductReviews { get; set; }
        public virtual List<Cart> Carts { get; set; }
        public virtual List<PetFood> PetFood { get; set;}
        public virtual List<OrderDet> OrderDets { get; set; }
        public virtual List<Complaint> Complaints { get; set; }
        public virtual List<Return> Returns { get; set; }
    }
}
