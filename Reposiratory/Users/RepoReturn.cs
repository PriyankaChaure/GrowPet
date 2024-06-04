using Core;
using Entities;
using Reposiratory.Admin;
using Reposiratory.Store1;
using Reposiratory.ViewModels;
using Reposiratory.ViewModels.ChangePassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Users
{
    public class RepoReturn : RepoGeneric<Return>, IReturn
    {
        ContextClass cc;
        public RepoReturn(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }

        public ChangePasswordResultVM AddReturns(ReturnVM rec)
        {
            ChangePasswordResultVM res = new ChangePasswordResultVM();
            try
            {
                Refund refund = new Refund();
                refund.ReturnId = rec.ReturnId;
                refund.RefundDate = DateTime.Now;
                refund.RefundAmount = rec.ProductPrice;
                this.cc.Refunds.Add(refund);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Product Refunded Successfully!";

            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }
            return res;
        }

        public List<ReturnVM> GetAllByStoreId(long storeid)
        {
            var re = this.cc.Returns.Where(p => p.Orders.StoreId == storeid).ToList();
            if (re != null)
            {
                var s = from t1 in this.cc.Returns
                        join t2 in this.cc.Refunds
                        on t1.ReturnId equals t2.ReturnId
                        into g
                        from t2 in g.DefaultIfEmpty()
                        join t4 in this.cc.Products
                        on t1.ProductId equals t4.ProductId
                        where t1.Orders.StoreId == storeid && t1.ReturnId != t2.ReturnId
                        select new ReturnVM
                        {
                            ReturnId = t1.ReturnId,
                            ReturnDate = t1.ReturnDate,
                            ReturnReason = t1.ReturnReason,
                            OrderId = t1.OrderId,
                            ProductId = t1.ProductId,
                            ProductType = t4.ProductType,
                            PetName = t4.Pets.FirstOrDefault().PetName,
                            FoodName = t4.PetFood.FirstOrDefault().FoodName,
                            ProductName = t4.PetProducts.FirstOrDefault().ProductName
                        };

                return s.ToList();

            }
            else
                return null;
        }

        public List<ReturnVM> GetAllByUserId(long userid)
        {
            var re = this.cc.Returns.Where(p => p.Orders.UserId == userid).ToList();
            if (re != null)
            {
                var s = from t1 in this.cc.Returns
                        join t2 in this.cc.Refunds
                        on t1.ReturnId equals t2.ReturnId
                        into g
                        from t2 in g.DefaultIfEmpty()
                        join t4 in this.cc.Products
                        on t1.ProductId equals t4.ProductId
                        where t1.Orders.UserId == userid && t1.ReturnId != t2.ReturnId
                        select new ReturnVM
                        {
                            ReturnId = t1.ReturnId,
                            ReturnDate = t1.ReturnDate,
                            ReturnReason = t1.ReturnReason,
                            OrderId = t1.OrderId,
                            ProductId = t1.ProductId,
                            ProductType = t4.ProductType,
                            PetName = t4.Pets.FirstOrDefault().PetName,
                            FoodName = t4.PetFood.FirstOrDefault().FoodName,
                            ProductName = t4.PetProducts.FirstOrDefault().ProductName
                        };

                return s.ToList();

            }
            else
                return null;
        }

        public ReturnVM GetRefundDetails(long returnid)
        {
            var v = (from t in this.cc.Refunds
                    where t.ReturnId == returnid
                    select new ReturnVM
                    {
                        ReturnId = t.ReturnId,
                       RefundDate=t.RefundDate,
                       RefundAmount= t.RefundAmount,

                    }).FirstOrDefault();
            return v;
           
        }

        public ReturnVM GetReturnId(long returnid)
        {
           var v =(from t1 in this.cc.Returns
                   join t2 in this.cc.Refunds
                   on t1.ReturnId equals t2.ReturnId
                   into g
                   from t2 in g.DefaultIfEmpty()
                   join t4 in this.cc.Products
                   on t1.ProductId equals t4.ProductId
                   where t1.ReturnId== returnid
                   select new ReturnVM
                   {
                       ReturnId = t1.ReturnId,
                       ReturnDate = t1.ReturnDate,
                       ReturnReason = t1.ReturnReason,
                       OrderId = t1.OrderId,
                       ProductId = t1.ProductId,
                       ProductType = t4.ProductType,
                       PetName = t4.Pets.FirstOrDefault().PetName,
                       FoodName = t4.PetFood.FirstOrDefault().FoodName,
                       ProductName = t4.PetProducts.FirstOrDefault().ProductName,
                       ProductPrice=t4.ProductPrice
                   }).FirstOrDefault();

            return v;
        }
    }
}
