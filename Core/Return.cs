using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblReturn")]
    public  class Return
    {
        [Key]
        public Int64 ReturnId { get; set; }
        [ForeignKey("Product")]
        public Int64 ProductId { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("Orders")]
        public Int64 OrderId { get; set; }
        public virtual Order Orders { get; set; }
        [Required(ErrorMessage = "Return Date Require!")]
        public DateTime ReturnDate { get; set; }
        [Required(ErrorMessage = "Return Reason Require!")]
        public string ReturnReason {  get; set; }
        public virtual List<Refund> Refunds { get; set; }
    }
}
