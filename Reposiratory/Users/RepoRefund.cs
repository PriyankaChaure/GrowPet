using Core;
using Entities;
using Reposiratory.Admin;
using Reposiratory.Store1;
using Reposiratory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Users
{
    public class RepoRefund : RepoGeneric<Refund>, IRefund
    {
        ContextClass cc;
        public RepoRefund(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<ReturnVM> GetAllByRefund(long storeid)
        {
            var re = this.cc.Returns.Where(p => p.Orders.StoreId == storeid).ToList();
            if (re != null)
            {
                var s = from t1 in this.cc.Returns
                        join t2 in this.cc.Refunds
                        on t1.ReturnId equals t2.ReturnId 
                        join t4 in this.cc.Products
                        on t1.ProductId equals t4.ProductId
                        where t1.Orders.StoreId == storeid
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

        public List<ReturnVM> GetAllByUserRefund(long userid)
        {
            var re = this.cc.Returns.Where(p => p.Orders.UserId == userid).ToList();
            if (re != null)
            {
                var s = from t1 in this.cc.Returns
                        join t2 in this.cc.Refunds
                        on t1.ReturnId equals t2.ReturnId
                        join t4 in this.cc.Products
                        on t1.ProductId equals t4.ProductId
                        where t1.Orders.UserId == userid
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
    }
}
