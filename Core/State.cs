using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblState")]
    public class State
    {
        [Key]
        public Int64 StateId { get; set; }
       // [Required(ErrorMessage = "State Name Require!")]
        public string StateName { get; set; }
        [ForeignKey("Country")]
        public Int64 CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual List<City> City { get; set; }
        
        //public State()
        //{
        //    Country = new Country();
        //}
    }
}
