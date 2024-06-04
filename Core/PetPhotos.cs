using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblPetPhotos")]
    public class PetPhotos
    {
        [Key]
        public Int64 PetPhotosId { get; set; }
        [ForeignKey("Pet")]
        public Int64 PetId { get; set; }
        public virtual Pet Pet { get; set; }
        [Required(ErrorMessage = "  Photo Title Require!")]
        public string PhotoTitle {  get; set; }
        [Required(ErrorMessage = "  Photo Path Require!")]
        public string PhotoPath {  get; set; }
    }
}
