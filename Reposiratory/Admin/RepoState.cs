using Core;
using Entities;
using Reposiratory.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Admin
{
    public class RepoState: RepoGeneric<State>, IState
    {
        ContextClass cc;
        public RepoState(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<StateVM> GetStateByCountryId(long countryid)
        {
            var v = from t in this.cc.States
                    where t.CountryId == countryid
                    select new StateVM
                    {
                        StateId = t.StateId,
                        StateName = t.StateName
                    };

            return v.ToList();
        }
    }
}
