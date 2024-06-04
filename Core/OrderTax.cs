using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblOrderTax")]
    public class OrderTax
    {
        [Key]
        public Int64 OrderTaxId {  get; set; }
        [ForeignKey("Orders")]
        public Int64 OrderId { get; set; }
        public virtual Order Orders { get; set; }
        [ForeignKey("Tax")]
        public Int64 TaxId { get; set; }
        public virtual Tax Tax { get; set; }
        [Required(ErrorMessage = "Tax Amount Require!")]
        public decimal TaxAmount {  get; set; }
    }
}
