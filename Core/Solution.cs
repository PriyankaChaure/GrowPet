using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblSolution")]
    public  class Solution
    {
        [Key]
        public Int64 SolutionId { get; set; }
        [Required(ErrorMessage = "Solution Date Require!")]
        public DateTime SolutionDate { get; set; }
        [Required(ErrorMessage = "Solution Description Require!")]
        public string SolutionDesc {  get; set; }
        [ForeignKey("Complaints")]
        public Int64 ComplaintId { get; set; }
        public virtual Complaint Complaints { get; set; }
    }
}
