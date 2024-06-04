using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.ViewModels
{
    public  class CountryVM
    {
        public Int64 CityId {  get; set; }
        public string CityName { get; set; }
        public Int64 StateId { get; set; }
        public string StateName { get; set; }
        public Int64 CountryId { get; set; }
      
        public string CountryName { get; set; }
    }
}
