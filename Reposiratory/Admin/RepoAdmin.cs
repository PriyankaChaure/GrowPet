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
    public class RepoAdmin : IAdmin
    {
        ContextClass cc;
        public RepoAdmin(ContextClass cc)
        {
            this.cc = cc;
        }

        public ChangePasswordResultVM ChangePassword(ChangePasswordVM rec, Int64 id)
        {
            ChangePasswordResultVM res = new ChangePasswordResultVM();
            var oldrec = this.cc.Admins.Find(id);
            if (oldrec.Password == rec.OldPassword)
            {
                oldrec.Password = rec.NewPassword;
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Password Changed Successfully!";
            }
            else
            {
                res.IsSuccess = false;
                res.Message = "Invalid Old Password!";
            }
            return res;
        }

        public ChangePasswordResultVM EditProfile(AdminVM rec, long id)
        {
            ChangePasswordResultVM res = new ChangePasswordResultVM();
            try
            {
                var oldrec = this.cc.Admins.Find(id);
                oldrec.FirstName = rec.FirstName;
                oldrec.LastName = rec.LastName;
                oldrec.Address = rec.Address;
                oldrec.EmailId = rec.EmailId;
                oldrec.MobileNo = rec.MobileNo;
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Profile Updated!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }

            return res;
        }

        public AdminVM GetById(long id)
        {
            var rec = (from t in this.cc.Admins
                       where t.AdminId == id
                       select new AdminVM
                       {
                           FirstName = t.FirstName,
                           LastName = t.LastName,
                           Address = t.Address,
                           EmailId = t.EmailId,
                           MobileNo = t.MobileNo,

                       }).FirstOrDefault();
            return rec;
        }

        public LoginResultVM Login(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var urec = this.cc.Admins.SingleOrDefault(p => p.EmailId == rec.EmailId && p.Password == rec.Password);
            if (urec != null)
            {
                res.IsSuccess = true;
                res.LoggedInId = urec.AdminId;
                res.LoggedInName = urec.FullName;
            }
            else
            {
                res.IsSuccess = false;
                res.Message = "Invalid EmailId And Password!";
            }
            return res;
        }


    }
}
