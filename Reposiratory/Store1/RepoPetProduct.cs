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
    public  class RepoPetProduct : RepoGeneric<PetProduct>, IPetProduct
    {
        ContextClass cc;
        public RepoPetProduct(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }

        public RepoResult AddPetProduct(PetProductVM rec)
        {
            RepoResult res = new RepoResult();
            try
            {
                PetProduct p = new PetProduct();
                p.ProductName = rec.ProductName;
                p.MfgName = rec.MfgName;
                p.ProductDesc = rec.ProductDesc;
                p.ProductId = rec.ProductId;
                p.Product.ProductType = rec.ProductType;
                p.Product.ProductPrice = rec.ProductPrice;

                p.Product.StoreId = rec.StoreId;

                p.ActualFile = rec.ActualFile;
                p.PhotoPath = rec.PhotoPath;

                this.cc.PetsProducts.Add(p);
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

        public RepoResult DeletePetProduct(PetProductVM rec)
        {
            RepoResult res = new RepoResult();
            try
            {
                Product prod = this.cc.Products.Find(rec.ProductId);
                prod.ProductPrice = rec.ProductPrice;
                prod.StoreId = rec.StoreId;
                prod.ProductType = rec.ProductType;
                this.cc.Products.Remove(prod);

                PetProduct p = this.cc.PetsProducts.Find(rec.PetProductId);
                p.ProductName = rec.ProductName;
                p.MfgName = rec.MfgName;
                p.ProductDesc = rec.ProductDesc;
                p.Product.ProductPrice = rec.ProductPrice;
                p.Product.ProductType = rec.ProductType;
                p.Product.StoreId = rec.StoreId;
                p.ProductId = rec.ProductId;
                p.ActualFile = rec.ActualFile;
                p.PhotoPath = rec.PhotoPath;
                this.cc.PetsProducts.Remove(p);

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

        public RepoResult EditPetProduct(PetProductVM rec)
        {
            RepoResult res = new RepoResult();
            try
            {
                Product prod = this.cc.Products.Find(rec.ProductId);
                prod.ProductPrice = rec.ProductPrice;
                prod.StoreId = rec.StoreId;
                prod.ProductType = rec.ProductType;

                PetProduct p = this.cc.PetsProducts.Find(rec.PetProductId);
                p.ProductName = rec.ProductName;
                p.MfgName = rec.MfgName;
                p.ProductDesc = rec.ProductDesc;
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


        public PetProductVM GetByPetProductId(long id)
        {
            var rec = (from t1 in this.cc.PetsProducts
                       join t2 in this.cc.Products
                       on t1.ProductId equals t2.ProductId
                       where t1.PetProductId == id
                       select new PetProductVM
                       {
                           PetProductId = t1.PetProductId,
                           ProductName = t1.ProductName,
                           MfgName = t1.MfgName,
                           ProductDesc = t1.ProductDesc,
                           ProductId = t2.ProductId,
                           PhotoPath = t1.PhotoPath,
                           ActualFile = t1.ActualFile,
                           ProductPrice = t2.ProductPrice,
                           StoreId = t2.StoreId,
                           ProductType = t2.ProductType,
                       }).FirstOrDefault();
            return rec;

        }

        public List<PetProduct> SearchByProductProperty(string productname)
        {
            var v = from t in this.cc.PetsProducts
                    where t.ProductName.StartsWith(productname)
                    select t;
            return v.ToList();
        }
        public List<PetProduct> GetAllByStoreId(long storeid)
        {
            return this.cc.PetsProducts.Where(p => p.Product.StoreId == storeid).ToList();
        }
    }
}
