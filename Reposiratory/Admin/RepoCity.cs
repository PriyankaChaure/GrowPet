using Core;
using Entities;
using Reposiratory.ViewModels;
using Reposiratory.ViewModels.ChangePassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Admin
{
    public class RepoCity : RepoGeneric<City>, ICity
    {
        ContextClass cc;
        public RepoCity(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }

        public void AddCity(CountryVM rec)
        {
            City city = new City();
            city.CityId = rec.CityId;
            city.CityName = rec.CityName;
            city.StateId = rec.StateId;
            this.cc.Cities.Add(city);
            this.cc.SaveChanges();
        }

        public void EditCity(CountryVM rec)
        {
            City city = new City();
            city.CityId = rec.CityId;
            city.CityName = rec.CityName;
            city.StateId= rec.StateId;

           
            this.cc.Cities.Add(city);
            this.cc.SaveChanges();
        }


        public List<CityVM> GetCityByStateId(long stateid)
        {
            var v = from t in this.cc.Cities
                    where t.StateId == stateid
                    select new CityVM
                    {
                        CityId = t.CityId,
                        CityName = t.CityName
                    };

            return v.ToList();
        }
    }
}
