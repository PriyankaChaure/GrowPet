using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblPetType")]
    public class PetType
    {
        [Key]
        public Int64  PetTypeId { get; set; }
        [Required(ErrorMessage = "pet Type Name Required!")]
        public string PetTypeName { get; set; }
        public virtual List<Pet> Pets { get; set; }
    }
}
