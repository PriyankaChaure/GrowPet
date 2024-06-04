using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblOffer")]
    public class Offer
    {
        [Key]
        public Int64 OfferId { get; set; }
        [Required(ErrorMessage = "Offer Name Require!")]
        public string OfferName {  get; set; }
        [Required(ErrorMessage = "Discount Require!")]
        public decimal Discount {  get; set; }
        [ForeignKey("Store")]
        public Int64 StoreId { get; set; }
        public virtual Store Store { get; set; }

    }
}
