using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblCategory")]
    public class Category
    {
        [Key]
        public Int64 CategoryId { get; set; }
        [Required(ErrorMessage ="Category Name Required!")]
        public string CategoryName { get; set; }   
      //  public virtual List<PetProduct> PetProducts { get; set; }
    }
}
