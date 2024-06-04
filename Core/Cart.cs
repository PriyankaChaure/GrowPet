using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblCart")]
    public  class Cart
    {
        [Key]
        public Int64 CartId {  get; set; }
        [Required(ErrorMessage = "Cart Date Require!")]
        public DateTime CartDate { get; set; }
        [Required(ErrorMessage = "Quantity Require!")]
        public int Quantity {  get; set; }
        [Required(ErrorMessage = "Price Require!")]
        public decimal Price {  get; set; }
        [ForeignKey("User")]
        public Int64 UserId { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("Product")]
        public Int64 ProductId { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("Store")]
        public Int64 StoreId { get; set; }
        public virtual Store Store { get; set; }
        public virtual OrderTax OrderTax { get; set; }
    }
}
