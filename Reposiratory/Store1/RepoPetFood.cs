using Core;
using Entities;
using Reposiratory.Admin;
using Reposiratory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Store1
{
    public class RepoPetFood : RepoGeneric<PetFood>, IPetFood
    {
        ContextClass cc;
        public RepoPetFood(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }

        public RepoResult AddPetFood(PetFoodVM rec)
        {
            RepoResult res = new RepoResult();
            try
            {
                PetFood p = new PetFood();
                p.FoodName = rec.FoodName;
                p.MfgName = rec.MfgName;
                p.FoodDesc = rec.FoodDesc;
                p.GoodFoodAccordingToPetAge = rec.GoodFoodAccordingToPetAge;

                p.ProductId = rec.ProductId;
                p.Product.ProductType = rec.ProductType;
                p.Product.ProductPrice = rec.ProductPrice;
                p.Product.StoreId = rec.StoreId;

                p.ActualFile = rec.ActualFile;
                p.PhotoPath = rec.PhotoPath;

                this.cc.PetFoods.Add(p);
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

        public RepoResult DeletePetFood(PetFoodVM rec)
        {
            RepoResult res = new RepoResult();
            try
            {
                Product prod = this.cc.Products.Find(rec.ProductId);
                prod.ProductPrice = rec.ProductPrice;
                prod.StoreId = rec.StoreId;
                prod.ProductType = rec.ProductType;
                this.cc.Products.Remove(prod);

                PetFood p = this.cc.PetFoods.Find(rec.FoodId);
                p.FoodName = rec.FoodName;
                p.MfgName = rec.MfgName;
                p.FoodDesc = rec.FoodDesc;
                p.GoodFoodAccordingToPetAge = rec.GoodFoodAccordingToPetAge;
                p.Product.ProductPrice = rec.ProductPrice;
                p.Product.ProductType = rec.ProductType;
                p.Product.StoreId = rec.StoreId;
                p.ProductId = rec.ProductId;
                p.ActualFile = rec.ActualFile;
                p.PhotoPath = rec.PhotoPath;
                this.cc.PetFoods.Remove(p);

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

        public RepoResult EditPetFood(PetFoodVM rec)
        {
            RepoResult res = new RepoResult();
            try
            {
                Product prod = this.cc.Products.Find(rec.ProductId);
                prod.ProductPrice = rec.ProductPrice;
                prod.StoreId = rec.StoreId;
                prod.ProductType = rec.ProductType;

                PetFood p = this.cc.PetFoods.Find(rec.FoodId);
                p.FoodName = rec.FoodName;
                p.MfgName = rec.MfgName;
                p.GoodFoodAccordingToPetAge = rec.GoodFoodAccordingToPetAge; 
                p.FoodDesc = rec.FoodDesc;

                p.Product.ProductPrice = rec.ProductPrice;
                p.Product.ProductType = rec.ProductType;
                p.Product.StoreId = rec.StoreId;
                p.ProductId = rec.ProductId;
                p.ActualFile = rec.ActualFile;
                p.PhotoPath = rec.PhotoPath;


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

        public PetFoodVM GetByPetFoodId(long id)
        {
            var rec = (from t1 in this.cc.PetFoods
                       join t2 in this.cc.Products
                       on t1.ProductId equals t2.ProductId
                       where t1.FoodId == id
                       select new PetFoodVM
                       {
                           FoodId = t1.FoodId,
                           FoodName = t1.FoodName,
                           MfgName = t1.MfgName,
                           FoodDesc = t1.FoodDesc,
                          GoodFoodAccordingToPetAge=t1.GoodFoodAccordingToPetAge,
                           ProductId = t2.ProductId,
                           PhotoPath = t1.PhotoPath,
                           ActualFile = t1.ActualFile,
                           ProductPrice = t2.ProductPrice,
                           StoreId = t2.StoreId,
                           ProductType = t2.ProductType,
                       }).FirstOrDefault();
            return rec;
        }

        public List<PetFood> SearchByFoodProperty(string foodname)
        {
            var v = from t in this.cc.PetFoods
                    where t.FoodName.StartsWith(foodname)
                    select t;
            return v.ToList();
        }
        public List<PetFood> GetAllByStoreId(long storeid)
        {
            return this.cc.PetFoods.Where(p => p.Product.StoreId == storeid).ToList();
        }
    }
}
