using Core;
using Entities;
using Reposiratory.Admin;
using Reposiratory.Store1;
using Reposiratory.ViewModels;
using Reposiratory.ViewModels.ChangePassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Store1
{
    public class RepoStore : RepoGeneric<Store>,IStore
    {
        ContextClass cc;
        public RepoStore(ContextClass cc):base(cc)
        {
            this.cc = cc;
        }

        public ChangePasswordResultVM ChangePassword(ChangePasswordVM rec, Int64 id)
        {
          ChangePasswordResultVM res = new ChangePasswordResultVM();
            var oldrec = this.cc.stores.Find(id);
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

        public ChangePasswordResultVM EditProfile(StoreVM rec, long id)
        {
            ChangePasswordResultVM res = new ChangePasswordResultVM();
            try
            {
                var oldrec = this.cc.stores.Find(id);
                oldrec.FirstName = rec.FirstName;
                oldrec.LastName = rec.LastName;
                oldrec.Address = rec.Address;
                oldrec.EmailId = rec.EmailId;
                oldrec.MobileNo = rec.MobileNo;
                oldrec.IsActive = rec.IsActive;
                oldrec.CityId=rec.CityId;
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

        public StoreVM GetById(long id)
        {
            var rec = (from t in this.cc.stores
                       where t.StoreId == id
                       select new StoreVM
                       {
                          StoreName=t.StoreName,
                          FirstName=t.FirstName,
                          LastName = t.LastName,
                          Address=t.Address,
                          EmailId = t.EmailId,
                          MobileNo = t.MobileNo,
                          IsActive = t.IsActive,
                          CityId=t.CityId
                         
                       }).FirstOrDefault();
            return rec;
        }

        public LoginResultVM Login(LoginVM rec)
        {
            
            LoginResultVM res=new LoginResultVM();
            var urec=this.cc.stores.SingleOrDefault(p=>p.EmailId==rec.EmailId && p.Password==rec.Password);
            if(urec!=null)
            {
                res.IsSuccess = true;
                res.LoggedInId = urec.StoreId;
                res.LoggedInName = urec.StoreName;
            }
            else
            {
                res.IsSuccess = false;
                res.Message = "Invalid EmailId And Password!";
            }
            return res;
        }

        public void SignUp(StoreAddVM rec)
        {
            Store res = new Store();
            res.StoreName = rec.StoreName;
            res.FirstName = rec.FirstName;
            res.LastName = rec.LastName;
            res.Address = rec.Address;
            res.EmailId = rec.EmailId;
            res.Password = rec.Password;                                                                                                            
            res.MobileNo = rec.MobileNo;
            res.IsActive = rec.IsActive;
            res.CityId = rec.CityId;
            this.cc.stores.Add(res);
            this.cc.SaveChanges();

        }


      
    }
}
