//using Reposiratory.Admin;

using Core;
using Reposiratory.Admin;
using Reposiratory.ViewModels;
using Reposiratory.ViewModels.ChangePassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Store1
{
    public interface IStore: IGeneric<Store>
    {
        LoginResultVM Login(LoginVM rec);
        ChangePasswordResultVM ChangePassword(ChangePasswordVM rec,Int64 id);
        StoreVM GetById(Int64 id);
        ChangePasswordResultVM EditProfile(StoreVM rec, Int64 id);
        //void LogOut();
        void SignUp(StoreAddVM rec);

    }
}
