using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblProductReview")]
    public  class ProductReview
    {
        [Key]
        public Int64 ProductReviewId { get; set; }
        [ForeignKey("Product")]
        public Int64 ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Required(ErrorMessage = "Rating Require!")]
        public int Rating {  get; set; }
        [ForeignKey("User")]
        public Int64 UserId { get; set; }
        public virtual User User { get; set; }
        [Required(ErrorMessage = "Review Description Require!")]
        public string ReviewDesc {  get; set; }
    }
}
