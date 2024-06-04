using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblTax")]
    public  class Tax
    {
        [Key]
        public Int64 TaxId { get; set; }
        [Required(ErrorMessage = "Tax Percentage Require!")]
        public decimal TaxPercentage {  get; set; }
        [Required(ErrorMessage = " HSNSACNo Require!")]
        public string HSNSACNo {  get; set; }
        public virtual List<OrderTax> OrderTaxes { get; set; }
    }
}
