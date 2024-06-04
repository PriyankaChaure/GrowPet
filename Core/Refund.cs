using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblRefund")]
    public class Refund
    {
        [Key]
        public Int64 RefundId { get; set; }
        [ForeignKey("Return")]
        public Int64 ReturnId { get; set; }
        public virtual Return Return { get; set; }
        [Required(ErrorMessage = "Refund Date Require!")]
        public DateTime RefundDate { get; set; }
        [Required(ErrorMessage = "Refund Amount Require!")]
        public decimal RefundAmount { get; set; }

    }
}
