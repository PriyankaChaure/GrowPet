using Core;
using Reposiratory.Admin;
using Reposiratory.ViewModels;
using Reposiratory.ViewModels.ChangePassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Users
{
    public interface IReturn:IGeneric<Return>
    {
        List<ReturnVM> GetAllByStoreId(Int64 storeid);
        List<ReturnVM> GetAllByUserId(Int64 userid);
        ReturnVM GetReturnId(Int64 returnid);
        ChangePasswordResultVM AddReturns(ReturnVM rec);
        ReturnVM GetRefundDetails(Int64 returnid);
    }
}
