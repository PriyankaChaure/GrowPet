using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblCountry")]
    public class Country
    {
        [Key]
        public Int64 CountryId { get; set; }
        [Required(ErrorMessage = "Country Name Require!")]
        public string CountryName {  get; set; }
        public virtual List<State> State { get; set; }
    }
}
