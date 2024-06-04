using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblPetProduct")]
    public  class PetProduct
    {
        [Key]
        public Int64 PetProductId {  get; set; }
        [Required(ErrorMessage = "product Name Require!")]
        public string ProductName {  get; set; }
        [Required(ErrorMessage = "Mfg Name Require!")]
        public string MfgName {  get; set; }
        [ForeignKey("Product")]
        public Int64 ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Required(ErrorMessage = "Product Description Require!")]
        public string ProductDesc {  get; set; }
        //[ForeignKey("Category")]
        //public Int64 CategoryId { get; set; }
        //public virtual Category Category { get; set; }
        [NotMapped]
        public IFormFile ActualFile { set; get; }
        [Required(ErrorMessage = "Photo Path Require!")]
        public string PhotoPath {  get; set; }
        public PetProduct()
        {
            Product = new Product();
        }

    }
}
