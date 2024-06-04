using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblDispatchOrder")]
    public class DispatchOrder
    {
        [Key]
        public Int64 DispatchOrederId { get; set; }
        [ForeignKey("Orders")]
        public Int64 OrderId { get; set; }
        public virtual Order Orders { get; set; }
        [Required(ErrorMessage = "Dispatch Date Require!")]
        public DateTime DispatchDate { get; set; }
        [Required(ErrorMessage = "Docket No Require!")]
        public string DocketNo {  get; set; }
        [ForeignKey("DispatchAgency")]
        public Int64 DispatchAgencyId { get; set; }
        public virtual DispatchAgency DispatchAgency { get; set; }
        [Required(ErrorMessage = "Expected Reach Date Require!")]
        public DateTime ExpectedReachDate { get; set; }
    }
}
