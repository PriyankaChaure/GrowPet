using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblStoreReview")]
    public  class StoreReview
    {
        [Key]
        public Int64 StoreReviewId { get; set; }
        [Required(ErrorMessage = "Review Require!")]
        public string Review {  get; set; }
        [ForeignKey("Store")]
        public Int64 StoreId { get; set; }
        public virtual Store Store { get; set; }
        [Required(ErrorMessage = "Rating Require!")]
        public int Rating {  get; set; }
        [ForeignKey("User")]
        public Int64 UserId { get; set; }
        public virtual User User { get; set; }
    }
}
