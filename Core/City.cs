using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblCity")]
    public class City
    {
        [Key]
        public Int64 CityId { get; set; }
        [Required(ErrorMessage = "City Name Require!")]
        public string CityName {  get; set; }
        [ForeignKey("State")]
        public Int64 StateId { get; set; }
        public virtual State State { get; set; }
        public virtual List<Store> Stores { get; set; }
        public virtual List<User> Users { get; set; }
        //public City()
        //{
        //   State = new State();
        //}
    }
}
