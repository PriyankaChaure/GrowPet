using Core;
using Reposiratory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Admin
{
    public interface IState: IGeneric<State>
    {
        List<StateVM> GetStateByCountryId(Int64 countryid);
    }
}
