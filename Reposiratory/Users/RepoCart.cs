using Castle.Core.Resource;
using Core;
using Entities;
using Microsoft.AspNetCore.Http;
using Reposiratory.Admin;
using Reposiratory.Enums;
using Reposiratory.ViewModels;
using Reposiratory.ViewModels.ChangePassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Users
{
    public class RepoCart: RepoGeneric<Cart>, ICart
    {
        ContextClass cc;
        public RepoCart(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }



        public ChangePasswordResultVM AddToCart(long petid, long userid, long storeid)
        {
            ChangePasswordResultVM res = new ChangePasswordResultVM();
            try
            {
                var v = (from t1 in this.cc.Pets
                         join t2 in this.cc.Products
                         on t1.ProductId equals t2.ProductId
                         join t3 in this.cc.Carts
                         on t2.ProductId equals t3.ProductId
                         where (t3.UserId == userid && t1.PetId == petid)
                         select new
                         {
                             CartId = t3.CartId,
                             CartDate = t3.CartDate,
                             Quantity = t3.Quantity,
                             Price = t3.Price,
                             UserId = t3.UserId,
                             StoreId = t3.StoreId,
                             ProductId = t3.ProductId,
                             PetTypeId = t1.PetTypeId,
                             PetTypeName = t1.PetType.PetTypeName,
                             PetFamilyId = t1.PetFamilyId,
                             PetFamilyName = t1.PetFamily.PetFamilyName,
                             PetName = t1.PetName,
                             Age = t1.Age,
                             Gender = t1.Gender,
                             PhotoPath = t1.PhotoPath,
                         }).SingleOrDefault();
                if (v != null)
                {
                    int r = v.Quantity;
                    r++;
                    
                    Cart c = this.cc.Carts.Find(v.CartId);
                   // c.CartId = v.CartId;
                    c.CartDate = v.CartDate;
                    c.Quantity = r;
                    c.Price = v.Price;
                    c.UserId = v.UserId;
                    c.StoreId = v.StoreId;
                    c.ProductId = v.ProductId;
                    //this.cc.Carts.Add(c);
                    this.cc.SaveChanges();
                }
              



                else
                {
                    var petrec = this.cc.Pets.Find(petid);
                    Cart newcart = new Cart();
                    newcart.CartDate = DateTime.Now;
                    newcart.Price = petrec.Product.ProductPrice;
                    newcart.Quantity = 1;
                    newcart.UserId = userid;
                    newcart.StoreId = storeid;
                    newcart.ProductId = petrec.ProductId;
                    this.cc.Carts.Add(newcart);
                    this.cc.SaveChanges();
                }
                res.IsSuccess = true;
                res.Message = "Product Added To Cart!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }
            return res;
        }
        public ChangePasswordResultVM AddToCartFood(long foodid, long userid, long storeid)
        {
            ChangePasswordResultVM res = new ChangePasswordResultVM();
            try
            {
                var v = (from t1 in this.cc.PetFoods
                         join t2 in this.cc.Products
                         on t1.ProductId equals t2.ProductId
                         join t3 in this.cc.Carts
                         on t2.ProductId equals t3.ProductId
                         where (t3.UserId == userid && t1.FoodId == foodid)
                         select new
                         {
                             CartId = t3.CartId,
                             CartDate = t3.CartDate,
                             Quantity = t3.Quantity,
                             Price = t3.Price,
                             UserId = t3.UserId,
                             StoreId = t3.StoreId,
                             ProductId = t3.ProductId,
                             FoodName=t1.FoodName,
                             MfgName=t1.MfgName,
                             FoodDesc=t1.FoodDesc,
                             GoodFoodForPetAge=t1.GoodFoodAccordingToPetAge,
                             PhotoPath = t1.PhotoPath,
                         }).SingleOrDefault();
                if (v != null)
                {
                    int r = v.Quantity;
                    r++;

                    Cart c = this.cc.Carts.Find(v.CartId);
                    c.CartDate = v.CartDate;
                    c.Quantity = r;
                    c.Price = v.Price;
                    c.UserId = v.UserId;
                    c.StoreId = v.StoreId;
                    c.ProductId = v.ProductId;
                    this.cc.SaveChanges();
                }




                else
                {
                    var foodrec = this.cc.PetFoods.Find(foodid);
                    Cart newcart = new Cart();
                    newcart.CartDate = DateTime.Now;
                    newcart.Price = foodrec.Product.ProductPrice;
                    newcart.Quantity = 1;
                    newcart.UserId = userid;
                    newcart.StoreId = storeid;
                    newcart.ProductId = foodrec.ProductId;
                    this.cc.Carts.Add(newcart);
                    this.cc.SaveChanges();
                }
                res.IsSuccess = true;
                res.Message = "Product Added To Cart!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }
            return res;
        }
        public ChangePasswordResultVM AddToCartProduct(long productid, long userid, long storeid)
        {
            ChangePasswordResultVM res = new ChangePasswordResultVM();
            try
            {
                var v = (from t1 in this.cc.PetsProducts
                         join t2 in this.cc.Products
                         on t1.ProductId equals t2.ProductId
                         join t3 in this.cc.Carts
                         on t2.ProductId equals t3.ProductId
                         where (t3.UserId == userid && t1.PetProductId == productid)
                         select new
                         {
                             CartId = t3.CartId,
                             CartDate = t3.CartDate,
                             Quantity = t3.Quantity,
                             Price = t3.Price,
                             UserId = t3.UserId,
                             StoreId = t3.StoreId,
                             ProductId = t3.ProductId,
                             ProductName=t1.ProductName,
                             MfgName=t1.MfgName,
                             ProductDesc=t1.ProductDesc,
                             PhotoPath = t1.PhotoPath,
                         }).SingleOrDefault();
                if (v != null)
                {
                    int r = v.Quantity;
                    r++;

                    Cart c = this.cc.Carts.Find(v.CartId);
                    c.CartDate = v.CartDate;
                    c.Quantity = r;
                    c.Price = v.Price;
                    c.UserId = v.UserId;
                    c.StoreId = v.StoreId;
                    c.ProductId = v.ProductId;
                    this.cc.SaveChanges();
                }




                else
                {
                    var productrec = this.cc.PetsProducts.Find(productid);
                    Cart newcart = new Cart();
                    newcart.CartDate = DateTime.Now;
                    newcart.Price = productrec.Product.ProductPrice;
                    newcart.Quantity = 1;
                    newcart.UserId = userid;
                    newcart.StoreId = storeid;
                    newcart.ProductId = productrec.ProductId;
                    this.cc.Carts.Add(newcart);
                    this.cc.SaveChanges();
                }
                res.IsSuccess = true;
                res.Message = "Product Added To Cart!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }
            return res;
        }
        public List<Cart> GetAllByUserID(long userid)
        {
            return this.cc.Carts.Where(p => p.UserId == userid).ToList();
        }

        public List<CartVM> GetAllByUserID1(long userid)
        {
           

            var v = from t1 in this.cc.Pets
                    join t2 in this.cc.Products
                    on t1.ProductId equals t2.ProductId
                    join t3 in this.cc.Carts
                    on t2.ProductId equals t3.ProductId
                    where t3.UserId == userid
                    select new CartVM
                    {
                        CartId=t3.CartId,
                        CartDate = t3.CartDate,
                        Quantity = t3.Quantity,
                        Price= t3.Price,
                        UserId=t3.UserId,
                        StoreId=t3.StoreId,
                        ProductId=t3.ProductId,
                        PetTypeId=t1.PetTypeId,
                        PetTypeName=t1.PetType.PetTypeName,
                        PetFamilyId=t1.PetFamilyId,
                        PetFamilyName=t1.PetFamily.PetFamilyName,
                        PetName=t1.PetName,
                        Age=t1.Age,
                        Gender=t1.Gender,
                        PhotoPath=t1.PhotoPath,

                    };
            return v.ToList();

        }
        public List<CartVM> GetAllByUserID2(long userid)
        {
            var v = from t1 in this.cc.PetFoods
                    join t2 in this.cc.Products
                    on t1.ProductId equals t2.ProductId
                    join t3 in this.cc.Carts
                    on t2.ProductId equals t3.ProductId
                    where t3.UserId == userid
                    select new CartVM
                    {
                        CartId=t3.CartId,
                        CartDate = t3.CartDate,
                        Quantity = t3.Quantity,
                        Price= t3.Price,
                        UserId=t3.UserId,
                        StoreId=t3.StoreId,
                        ProductId=t3.ProductId,
                        FoodName=t1.FoodName,
                        MfgName=t1.MfgName,
                        FoodDesc=t1.FoodDesc,
                        GoodFoodAccordingToPetAge=t1.GoodFoodAccordingToPetAge,
                        PhotoPath=t1.PhotoPath,

                    };
            return v.ToList();

        }
        public List<CartVM> GetAllByUserID3(long userid)
        {
            var v1 = from t1 in this.cc.PetsProducts
                    join t2 in this.cc.Products
                    on t1.ProductId equals t2.ProductId
                    join t3 in this.cc.Carts
                    on t2.ProductId equals t3.ProductId
                    where t3.UserId == userid
                   select new CartVM
                   {
                    CartId=t3.CartId,
                    CartDate = t3.CartDate,
                    Quantity = t3.Quantity,
                    Price= t3.Price,
                    UserId=t3.UserId,
                    StoreId=t3.StoreId,
                    ProductId=t3.ProductId,
                    ProductName=t1.ProductName,
                    MfgName=t1.MfgName,
                    ProductDesc=t1.ProductDesc,
                    PhotoPath=t1.PhotoPath,


            };
             return v1.ToList();
         

        }
        public int GetCartCount(long userid)
        {
            return this.cc.Carts.Where(p => p.UserId == userid).Count();
        }

        public ChangePasswordResultVM PlaceOrder(long userid,int pmode)
        {
            ChangePasswordResultVM res = new ChangePasswordResultVM();
            try
            {

                var carts = this.cc.Carts.Where(p => p.UserId == userid).Select(p=>p.StoreId).Distinct().ToList();
                foreach (var storeid in carts)
                {
                    var c = this.cc.Carts.Where(p => p.UserId == userid && p.StoreId==storeid);
                    Order rec = new Order();
                    rec.Orderdate = DateTime.Now;
                    rec.StoreId = storeid;
                    if (pmode == (int)PaymentEnum.CashOnDelivery)
                        rec.IsPaid = false;
                    else
                        rec.IsPaid = true;
                    rec.UserId = userid;

                    foreach (var temp in c)
                    {
                        OrderDet order = new OrderDet();
                        order.ProductId = temp.ProductId;
                        order.Quantity = temp.Quantity;
                        order.Price = temp.Price;
                        rec.OrderDets.Add(order);
                    }

                    if (pmode != (int)PaymentEnum.CashOnDelivery)
                    {
                        Payment ordp = new Payment();
                        ordp.PaymentDate = DateTime.Now;
                        ordp.PaymentAmount = c.Sum(p => p.Price * p.Quantity);
                        ordp.PaymentMode = pmode;
                        rec.Payments.Add(ordp);
                    }

                    this.cc.Orders.Add(rec);
                    this.cc.SaveChanges();
                  
                    
                }
                //empty cart
                var oldcar = this.cc.Carts.Where(p => p.UserId == userid);
                foreach (var temp in oldcar)
                {
                    this.cc.Carts.Remove(temp);
                }
                this.cc.SaveChanges();
                res.IsSuccess = true;
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
