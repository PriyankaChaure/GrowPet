using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblComplaint")]
    public  class Complaint
    {
        [Key]
        public Int64 ComplaintId { get; set; }
        [Required(ErrorMessage = "Complaint Date Require!")]
        public DateTime ComplaintDate { get; set; }
        [Required(ErrorMessage = "complaint Discription Require!")]
        public string ComplaintDesc {  get; set; }
        [ForeignKey ("Orders")]
        public Int64 OrderId { get; set; }
        public virtual Order Orders { get; set; }
        [ForeignKey("Product")]
        public Int64 ProductId { get; set; }
       // public virtual Product Product { get; set; }
        public virtual List<Product> Product { get; set; }
        public virtual List<Solution> Solutions { get; set; }
    }
}
