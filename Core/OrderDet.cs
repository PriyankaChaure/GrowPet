using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblOrderDet")]
    public class OrderDet
    {
        [Key]
        public Int64 OrderDetID { get; set; }
        [ForeignKey("Orders")]
        public Int64 OrderId { get; set; }
        public virtual Order Orders { get; set; }
        [ForeignKey("Product")]
        public Int64 ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Required(ErrorMessage = "Quantity Require!")]
        public int Quantity {  get; set; }
        [Required(ErrorMessage = "Price Require!")]
        public decimal Price { get; set; }
    }
}
