using Core;
using Entities;
using Reposiratory.Admin;
using Reposiratory.Users;
using Reposiratory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Store1
{
    public class RepoOrders : RepoGeneric<Order>, IOrders
    {
        ContextClass cc;
        public RepoOrders(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }

        public RepoResult AddReview(long userid)
        {
            RepoResult res = new RepoResult();
            try
            {

            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }

        public List<CartVM> GetAllByOrderID1(long orderid)
        {
             var v = this.cc.Orders.Where(p=>p.OrderId == orderid);
              if(v.Any())
            {
            var x = (from t1 in this.cc.Pets
                    join t2 in this.cc.Products
                    on t1.ProductId equals t2.ProductId 
                    join t4 in this.cc.Orders
                    on t2.StoreId equals t4.StoreId
                    join t5 in this.cc.OrderDets
                    on t4.OrderId equals t5.OrderId
                    where(t5.OrderId==orderid &&( t4.OrderId==t5.OrderId && t5.ProductId==t2.ProductId) )
                        select new CartVM
                        {
                            Quantity = t5.Quantity,
                            Price = t5.Price,
                            UserId = t4.User.UserId,
                            StoreId = t4.Store.StoreId,
                            ProductId = t1.Product.ProductId,
                            PetTypeId = t1.PetTypeId,
                            PetTypeName = t1.PetType.PetTypeName,
                            PetFamilyId = t1.PetFamilyId,
                            PetFamilyName = t1.PetFamily.PetFamilyName,
                            PetName = t1.PetName,
                            Age = t1.Age,
                            Gender = t1.Gender,
                            PhotoPath = t1.PhotoPath

                        }).Distinct();
                return x.ToList();
            }   
              else
           return new List<CartVM>();
        }

        public List<CartVM> GetAllByOrderID2(long orderid)
        {
            var v = this.cc.Orders.Where(p => p.OrderId == orderid);
            if (v.Any())
            {
                var x = (from t1 in this.cc.PetFoods
                        join t2 in this.cc.Products
                        on t1.ProductId equals t2.ProductId
                        join t4 in this.cc.Orders
                        on t2.StoreId equals t4.StoreId
                        join t5 in this.cc.OrderDets
                        on t4.OrderId equals t5.OrderId
                        where (t5.OrderId == orderid && (t4.OrderId == t5.OrderId && t5.ProductId == t2.ProductId))

                        select new CartVM
                        {
                           
                            Quantity = t5.Quantity,
                            Price = t5.Price,
                            UserId = t4.User.UserId,
                            StoreId = t4.Store.StoreId,
                            ProductId = t1.Product.ProductId,
                            FoodName = t1.FoodName,
                            MfgName = t1.MfgName,
                            FoodDesc = t1.FoodDesc,
                            GoodFoodAccordingToPetAge = t1.GoodFoodAccordingToPetAge,
                            PhotoPath = t1.PhotoPath

                        }).Distinct();
                return x.ToList();
            }
            return new List<CartVM>();
        }

        public List<CartVM> GetAllByOrderID3(long orderid)
        {
            var v = this.cc.Orders.Where(p => p.OrderId == orderid);
            if (v.Any())
            {

                var v1 = from t1 in this.cc.PetsProducts
                         join t2 in this.cc.Products
                         on t1.ProductId equals t2.ProductId
                         join t4 in this.cc.Orders
                         on t2.StoreId equals t4.StoreId
                         join t5 in this.cc.OrderDets
                         on t4.OrderId equals t5.OrderId
                         where (t5.OrderId == orderid && (t4.OrderId == t5.OrderId && t5.ProductId == t2.ProductId))

                         select new CartVM
                         {
                             
                             Quantity = t5.Quantity,
                             Price = t5.Price,
                             UserId = t4.User.UserId,
                             StoreId = t4.Store.StoreId,
                             ProductId = t1.Product.ProductId,
                             ProductName = t1.ProductName,
                             MfgName = t1.MfgName,
                             ProductDesc = t1.ProductDesc,
                             PhotoPath = t1.PhotoPath
                         };
                return v1.ToList();
            }
            return new List<CartVM>();
        }

        public List<Order> GetAllByStoreId(long storeid)
        {
            var re= this.cc.Orders.Where(p => p.StoreId == storeid).ToList();
            if (re != null)
            {
                var v = from t in this.cc.Orders
                        where t.StoreId == storeid
                        where !(from t1 in this.cc.DispatchOrders
                                select t1.OrderId ) 
                                .Contains(t.OrderId)
                        select t;
                return v.ToList();

            }
            else
                return re;
           
           
        }

        public List<Order> GetAllByUserId(long userid)
        {
            var re = this.cc.Orders.Where(p => p.UserId == userid).ToList();
            if (re != null)
            {
                var v = from t in this.cc.Orders
                        where t.UserId == userid
                        where !(from t1 in this.cc.DispatchOrders
                                select t1.OrderId)
                                .Contains(t.OrderId)
                        select t;
                return v.ToList();

            }
            else
                return re;


        }

        public List<Payment> GetCollections(string f, string t, long storeid)
        {
            DateTime fromDate = DateTime.Parse(f);
            DateTime toDate = DateTime.Parse(t);

            var p = from t1 in this.cc.Payments
                    join t2 in this.cc.Orders
                    on t1.OrderId equals t2.OrderId
                    where t2.StoreId == storeid
                    where t1.PaymentDate >= fromDate && t1.PaymentDate <= toDate
                    select t1;

            return p.ToList();
        }


        public RepoResult GetComplaint(Complaint rec)
        {
            RepoResult res = new RepoResult();
            try
            {

              Complaint c=new Complaint();
                c.ComplaintDate = rec.ComplaintDate;
                c.ComplaintDesc = rec.ComplaintDesc;
                c.OrderId=rec.OrderId;
                c.ProductId=rec.ProductId;
                this.cc.Complaints.Add(c);
                this.cc.SaveChanges();
                res.IsSuccess= true;
                res.Message = "Your Complaint Added Successfully!!!";
                return res;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }

        public List<Order> GetPendings(string f, string t, long storeid)
        {
            DateTime fromDate = DateTime.Parse(f);
            DateTime toDate = DateTime.Parse(t);

            var p = from t1 in this.cc.Orders
                    join t2 in this.cc.DispatchOrders
                    on t1.OrderId equals t2.OrderId
                    into g
                    from t2 in g.DefaultIfEmpty()
                    where t1.StoreId == storeid 
                    where ((t1.Orderdate >= fromDate && t1.Orderdate <= toDate) && t1.OrderId != t2.OrderId)
                    select t1;

            return p.ToList();

        }

        public List<ReturnVM> GetRefunds(string f, string t, long storeid)
        {
            DateTime fromDate = DateTime.Parse(f);
            DateTime toDate = DateTime.Parse(t);
            var v = from t1 in this.cc.Refunds
                    join t2 in this.cc.Returns
                    on t1.ReturnId equals t2.ReturnId
                    join t3 in this.cc.Products
                    on t2.ProductId equals t3.ProductId
                    where t2.Orders.StoreId == storeid
                    where t1.RefundDate >= fromDate && t1.RefundDate <= toDate
                    select new ReturnVM
                     {
                       OrderId=t2.OrderId,
                       ProductType=t2.Product.ProductType,
                       ProductId = t1.Return.ProductId,
                       PetName = t3.Pets.FirstOrDefault().PetName,
                       FoodName = t3.PetFood.FirstOrDefault().FoodName,
                       ProductName = t3.PetProducts.FirstOrDefault().ProductName,
                       ProductPrice = t3.ProductPrice,
                       RefundDate=t1.RefundDate,
                       RefundAmount=t1.RefundAmount
                    };
            return v.ToList();
        }

        public RepoResult GetReturn(Return rec)
        {
            RepoResult res = new RepoResult();
            try
            {

                Return r = new Return();
                r.ReturnDate= rec.ReturnDate;
                r.ReturnReason = rec.ReturnReason;
                r.OrderId = rec.OrderId;
                r.ProductId = rec.ProductId;
                this.cc.Returns.Add(r);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Your Returns Added Successfully!!!";
                return res;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }
    }
}
