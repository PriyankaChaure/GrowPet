using Reposiratory.ViewModels;
using Reposiratory.ViewModels.ChangePassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Admin
{
    public interface IAdmin
    {
        LoginResultVM Login(LoginVM rec);
        ChangePasswordResultVM ChangePassword(ChangePasswordVM rec,Int64 id);
        AdminVM GetById(Int64 id);
        ChangePasswordResultVM EditProfile(AdminVM rec, Int64 id);
       
        //void LogOut();

    }
}
