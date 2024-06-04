using Core;
using Reposiratory.Admin;
using Reposiratory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Users
{
    public interface IRefund:IGeneric<Refund>
    {
        List<ReturnVM> GetAllByRefund(long storeid);
        List<ReturnVM> GetAllByUserRefund(long userid);
    }
}
