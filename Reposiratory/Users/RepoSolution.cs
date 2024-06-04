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
    public class RepoSolution: RepoGeneric<Solution>, ISolution
    {
        ContextClass cc;
        public RepoSolution(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }

       
        public List<ComplaintVM> GetAllByComplaint(long storeid)
        {

            var re = this.cc.Complaints.Where(p => p.Orders.StoreId == storeid).ToList();
            if (re != null)
            {

                var s = from t1 in this.cc.Complaints
                        join t2 in this.cc.Solutions
                        on t1.ComplaintId equals t2.ComplaintId 
                        join t4 in this.cc.Products
                        on t1.ProductId equals t4.ProductId
                        where t1.Orders.StoreId == storeid
                        select new ComplaintVM
                        {
                            ComplaintId = t1.ComplaintId,
                            ComplaintDate = t1.ComplaintDate,
                            ComplaintDesc = t1.ComplaintDesc,
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

        public List<ComplaintVM> GetAllByUserComplaint(long userid)
        {
            var re = this.cc.Complaints.Where(p => p.Orders.UserId == userid).ToList();
            if (re != null)
            {
                var s = from t1 in this.cc.Complaints
                        join t2 in this.cc.Solutions
                        on t1.ComplaintId equals t2.ComplaintId
                        join t4 in this.cc.Products
                        on t1.ProductId equals t4.ProductId
                        where t1.Orders.UserId == userid
                        select new ComplaintVM
                        {
                            ComplaintId = t1.ComplaintId,
                            ComplaintDate = t1.ComplaintDate,
                            ComplaintDesc = t1.ComplaintDesc,
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

        public Solution GetSolutionByComplaintID(long complaintid)
        {
            return this.cc.Solutions.FirstOrDefault(p => p.ComplaintId == complaintid);
        }
    }
}
