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
    [Table("TblPet")]
    public  class Pet
    {
        [Key]
        public Int64 PetId { get; set; }
        [Required(ErrorMessage = "Pet Name Require!")]
        public string PetName { get; set; }
        [Required(ErrorMessage = "Pet Age Require!")]
        public Int64 Age {  get; set; }
        [Required(ErrorMessage = "Pet Gender Require!")]
        public int Gender {  get; set; }
        [ForeignKey("PetType")]
        public Int64 PetTypeId { get; set; }
        public virtual PetType PetType { get; set; }
        [ForeignKey("PetFamily")]
        public Int64 PetFamilyId { get; set; }
        public virtual PetFamily PetFamily { get; set; }
        [Required(ErrorMessage = "Pet Description Require!")]
        public string PetDesc {  get; set; }
        [NotMapped]
        public IFormFile ActualFile { set; get; }
      //  [Required(ErrorMessage = "Photo Path Require!")]
        public string PhotoPath {  get; set; }
        [ForeignKey("Product")]
        public Int64 ProductId { get; set; }
      
        public virtual Product Product { get; set; }   
        public virtual List<PetPhotos> PetPhotos { get; set; }
        public Pet()
        {
            Product=new Product();
        }
    }
}
