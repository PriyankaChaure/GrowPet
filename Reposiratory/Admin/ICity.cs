using Core;
using Reposiratory.ViewModels;
using Reposiratory.ViewModels.ChangePassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Admin
{
    public interface ICity:IGeneric<City>
    {
        List<CityVM> GetCityByStateId(Int64 stateid);
        void EditCity(CountryVM rec);
        void AddCity(CountryVM rec);
    }
}
