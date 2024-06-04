using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{

    [Table("TblPetFamily")]
    public  class PetFamily
    {
        [Key]
        public Int64 PetFamilyId { get; set; }
        [Required(ErrorMessage = "Pet Family Name Require!")]
        public string PetFamilyName { get; set; }
        public virtual List<Pet> Pets { get;}
    }
}

