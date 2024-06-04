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
    public class RepoStoreReview: RepoGeneric<StoreReview>, IReview
    {
        ContextClass cc;
        public RepoStoreReview(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }

        public ChangePasswordResultVM AddProductReview(StoreReviewVM rec, Int64 s)
        {
            ChangePasswordResultVM res = new ChangePasswordResultVM();
            var v=this.cc.Products.Where(p=>p.ProductId==rec.ProductId).FirstOrDefault();
            if (v != null)
            {
                try
                {
                    ProductReview p = new ProductReview();
                    p.ReviewDesc = rec.ReviewDesc;
                    p.ProductId = s;
                    p.UserId = rec.UserId;
                    p.Rating = rec.Rating;

                    this.cc.ProductReviews.Add(p);
                    this.cc.SaveChanges();
                    res.IsSuccess = true;
                    res.Message = "Your Product Review Added Successfully!!!";
                    return res;
                }
                catch (Exception ex)
                {
                    res.IsSuccess = false;
                    res.Message = ex.Message.ToString();
                }
            }
            return res;
        }

        public ChangePasswordResultVM AddStoreReview(StoreReviewVM rec)
        {
            ChangePasswordResultVM res = new ChangePasswordResultVM();
            try
            {

                StoreReview c = new StoreReview();
                c.Review = rec.Review;
                c.StoreId = rec.StoreId;
                c.UserId = rec.UserId;
                c.Rating = rec.Rating;
                this.cc.StoreReviews.Add(c);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Your Store Review Added Successfully!!!";
                return res;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }

        public List<StoreReviewVM> GetByAllProductsId(long userid)
        {
            //var s = from t1 in this.cc.ProductReviews
            //        join t2 in this.cc.Products
            //        on t1.ProductId equals t2.ProductId
                   
            //        select new StoreReviewVM
            //        {
            //            ProductType = t1.Product.ProductType,
            //            PetId = t1.Product.Pets.FirstOrDefault().PetId,
            //            PetName = t1.Product.Pets.FirstOrDefault().PetName,
            //            FoodId = t1.Product.PetFood.FirstOrDefault().FoodId,
            //            FoodName = t1.Product.PetFood.FirstOrDefault().FoodName,
            //            PetProductId = t1.Product.PetProducts.FirstOrDefault().PetProductId,
            //            ProductName = t1.Product.PetProducts.FirstOrDefault().ProductName,
            //            Rating = t1.Rating,
            //            UserId = t1.UserId,
            //            FullName = t1.User.FullName,
            //            ReviewDesc = t1.ReviewDesc,

            //        };

            var s = from t1 in this.cc.ProductReviews
                    join t4 in this.cc.Products
                     on t1.ProductId equals t4.ProductId
                    into g
                   // from t2 in g.DefaultIfEmpty()
                    select new StoreReviewVM
                    {
                        ReviewDesc = t1.ReviewDesc,
                        Rating=t1.Rating,
                        UserId = t1.UserId,
                        FullName = t1.User.FullName,
                        ProductId = t1.ProductId,
                        ProductType = t1.Product.ProductType,
                        PetName = t1.Product.Pets.FirstOrDefault().PetName,
                        FoodName = t1.Product.PetFood.FirstOrDefault().FoodName,
                        ProductName = t1.Product.PetProducts.FirstOrDefault().ProductName,
                        PhotoPath1=t1.Product.Pets.FirstOrDefault().PhotoPath,
                        PhotoPath2 = t1.Product.PetFood.FirstOrDefault().PhotoPath,
                        PhotoPath3 = t1.Product.PetProducts.FirstOrDefault().PhotoPath,
                    };

            return s.ToList();

            // return this.cc.ProductReviews.ToList();
        }



        public List<StoreReview> GetByAllStoresId(long userid)
        {
            return this.cc.StoreReviews.ToList();
        }

        public List<StoreReviewVM> GetByFoodId(long userid)
        {
            var v = this.cc.Orders.Where(p => p.UserId == userid).ToList();

            if (v != null)
            {

                var s = (from t1 in this.cc.Orders
                         join t2 in this.cc.OrderDets
                         on t1.OrderId equals t2.OrderId
                         join t3 in this.cc.Products
                         on t2.ProductId equals t3.ProductId
                         join t4 in this.cc.PetFoods
                         on t3.ProductId equals t4.ProductId
                         where t1.UserId == userid && t3.ProductId == t4.ProductId
                         select new StoreReviewVM
                         {
                             FoodId = t4.FoodId,
                             FoodName = t4.FoodName,
                             ProductId= t4.ProductId,


                         }).Distinct();

                return s.ToList();
            }
            else
                return null;
        }

        public List<StoreReviewVM> GetByPetId(long userid)
        {
            var v = this.cc.Orders.Where(p => p.UserId == userid).ToList();

            if (v != null)
            {

                var s = (from t1 in this.cc.Orders
                         join t2 in this.cc.OrderDets
                         on t1.OrderId equals t2.OrderId
                         join t3 in this.cc.Products
                         on t2.ProductId equals t3.ProductId
                         join t4 in this.cc.Pets
                         on t3.ProductId equals t4.ProductId    
                         where t1.UserId == userid && t3.ProductId==t4.ProductId
                         select new StoreReviewVM
                         {
                             PetId = t4.PetId,
                             PetName = t4.PetName,
                             ProductId= t4.ProductId

                         }).Distinct();

                return s.ToList();
            }
            else
                return null;
        }

        public List<StoreReviewVM> GetByProductId(long userid)
        {
            var v = this.cc.Orders.Where(p => p.UserId == userid).ToList();

            if (v != null)
            {

                var s = (from t1 in this.cc.Orders
                         join t2 in this.cc.OrderDets
                         on t1.OrderId equals t2.OrderId
                         join t3 in this.cc.Products
                         on t2.ProductId equals t3.ProductId
                         join t4 in this.cc.PetsProducts
                         on t3.ProductId equals t4.ProductId
                         where t1.UserId == userid && t3.ProductId == t4.ProductId
                         select new StoreReviewVM
                         {
                             PetProductId = t4.PetProductId,
                             ProductName = t4.ProductName,
                             ProductId = t4.ProductId

                         }).Distinct();

                return s.ToList();
            }
            else
                return null;
        }

        public List<StoreReviewVM> GetByStoreId(long userid)
        {
           var v= this.cc.Orders.Where(p => p.UserId == userid).Select(p=>p.StoreId).ToList();

            if (v != null)
            {

                var s = (from t1 in this.cc.Orders
                        join t2 in this.cc.OrderDets
                        on t1.OrderId equals t2.OrderId
                        join t3 in this.cc.Products
                        on t2.ProductId equals t3.ProductId
                        where t1.UserId == userid && t1.StoreId == t3.StoreId
                        select new StoreReviewVM
                        {
                            StoreId = t1.StoreId,
                            StoreName = t1.Store.StoreName

                        }).Distinct();

                return s.ToList();
            }
            else
                return null;
        }

        List<Order> IReview.GetAllByUserId(long userid)
        {
            var v = from t in this.cc.Orders
                    join t1 in this.cc.OrderDets
                    on t.OrderId equals t1.OrderId
                    where t.UserId == userid
                    select t;
            return v.ToList();
             
        }
    }
}
