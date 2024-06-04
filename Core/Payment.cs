using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblPayment")]
    public class Payment
    {
        [Key]
        public Int64 PaymentId { get; set; }
        [ForeignKey("Orders")]
        public Int64 OrderId { get; set; }
        public virtual Order Orders { get; set; }
        [Required(ErrorMessage = "Payment Date Require!")]
        public DateTime PaymentDate { get; set; }
        [Required(ErrorMessage = "Payment Amount Require!")]
        public decimal PaymentAmount { get; set; }
        [Required(ErrorMessage = "Payment Mode Require!")]
        public int PaymentMode { get; set; }
    }
}
