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
    [Table("TblPetFood")]
    public  class PetFood
    {
        [Key]
        public Int64 FoodId { get; set; }
        [Required(ErrorMessage = "Food Name Require!")]
        public string FoodName { get; set; }
        [Required(ErrorMessage = "Mfg Name Require!")]
        public string MfgName {  get; set; }
        [Required(ErrorMessage = "Food Description Require!")]
        public string FoodDesc {  get; set; }
        [NotMapped]
        public IFormFile ActualFile { set; get; }
        [Required(ErrorMessage = "Photo Path Require!")]
        public string PhotoPath {  get; set; }
        [ForeignKey("Product")]
        public Int64 ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Required(ErrorMessage = "Select Food According To Pet Age Require!")]
        public int GoodFoodAccordingToPetAge {  get; set; }
        public PetFood()
        {
            Product = new Product();
        }

    }
}
