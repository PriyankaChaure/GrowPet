using Reposiratory.Admin;
using Reposiratory.ViewModels.ChangePassword;
using Reposiratory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reposiratory.Store1;

namespace Reposiratory.Users
{
    public interface IUser
    {
        LoginResultVM Login(LoginVM rec);
        ChangePasswordResultVM ChangePassword(ChangePasswordVM rec, Int64 id);
        UserVM GetById(Int64 id);
        ChangePasswordResultVM EditProfile(UserVM rec, Int64 id);
        void SignUp(UserAddVM rec);
    }
}
