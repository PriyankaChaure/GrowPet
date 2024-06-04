using Core;
using Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Reposiratory.Admin;
using Reposiratory.Enums;
using Reposiratory.Store1;
using Reposiratory.ViewModels;
using Reposiratory.ViewModels.ChangePassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Reposiratory.Store1
{
    public class RepoPet : RepoGeneric<Pet>, IPet
    {
        ContextClass cc;
        public RepoPet(ContextClass cc):base(cc)
        {
            this.cc = cc;
        }

        public RepoResult AddPet(PetVM rec)
        {

            RepoResult res = new RepoResult();
            try
            {
                Pet p = new Pet();
                p.PetName = rec.PetName;
                p.Age = rec.Age;
                p.Gender = rec.Gender;
                p.PetTypeId = rec.PetTypeId;          
                p.PetFamilyId = rec.PetFamilyId;
                p.PetDesc = rec.PetDesc;
                p.Product.ProductPrice= rec.ProductPrice;
                p.Product.ProductType= rec.ProductType;
                p.Product.StoreId= rec.StoreId;
                p.ProductId = rec.ProductId;
                p.ActualFile = rec.ActualFile;
                p.PhotoPath =rec.PhotoPath;
               
                this.cc.Pets.Add(p);
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

        public RepoResult DeletePet(PetVM rec)
        {
            RepoResult res = new RepoResult();
            try
            {
                Product prod = this.cc.Products.Find(rec.ProductId);
                prod.ProductPrice = rec.ProductPrice;
                prod.StoreId = rec.StoreId;
                prod.ProductType = rec.ProductType;
                this.cc.Products.Remove(prod);
                Pet p = this.cc.Pets.Find(rec.PetId);
                p.PetName = rec.PetName;
                p.Age = rec.Age;
                p.Gender = rec.Gender;
                p.PetTypeId = rec.PetTypeId;
                p.PetFamilyId = rec.PetFamilyId;
                p.PetDesc = rec.PetDesc;
                p.Product.ProductPrice = rec.ProductPrice;
                p.Product.ProductType = rec.ProductType;
                p.Product.StoreId = rec.StoreId;
                p.ProductId = rec.ProductId;
                p.ActualFile = rec.ActualFile;
                p.PhotoPath = rec.PhotoPath;
                this.cc.Pets.Remove(p);

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

        public RepoResult EditPet(PetVM rec)
        {
            RepoResult res = new RepoResult();
            try
            {
                Product prod =this.cc.Products.Find(rec.ProductId);
                prod.ProductPrice = rec.ProductPrice;
                prod.StoreId = rec.StoreId;
                prod.ProductType = rec.ProductType;
              
                Pet p =this.cc.Pets.Find(rec.PetId);
                p.PetName = rec.PetName;
                p.Age = rec.Age;
                p.Gender = rec.Gender;
                p.PetTypeId = rec.PetTypeId;               
                p.PetFamilyId = rec.PetFamilyId;
                p.PetDesc = rec.PetDesc;
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

        public List<Pet> GetAllByStoreId(long storeid)
        {
            return this.cc.Pets.Where(p=>p.Product.StoreId == storeid).ToList();
        }

        public PetVM GetByPetId(long id)
        {
            var rec = (from t1 in this.cc.Pets
                       join t2 in this.cc.PetTypes
                       on t1.PetTypeId equals t2.PetTypeId
                       join t3 in this.cc.PetsFamily
                       on t1.PetTypeId equals t3.PetFamilyId
                       join t4 in this.cc.Products
                       on t1.ProductId equals t4.ProductId
                       where t1.PetId==id
                       select new PetVM
                       {
                            PetId = t1.PetId,
                            PetName=t1.PetName,
                            Age=t1.Age,
                            Gender=t1.Gender,
                            PetTypeId=t1.PetTypeId,
                            PetFamilyId=t1.PetFamilyId,
                            PetDesc=t1.PetDesc,
                            ProductId=t4.ProductId,
                            PhotoPath=t1.PhotoPath,
                            ActualFile=t1.ActualFile,
                            ProductPrice=t4.ProductPrice,
                            StoreId=t4.StoreId,
                            ProductType=t4.ProductType,
                            PetTypeName=t2.PetTypeName,
                            PetFamilyName=t3.PetFamilyName,
                       }).FirstOrDefault();
            return rec;

        }

        public List<Pet> SearchByProperty(Int64 type = 0, Int64 family = 0)
        {
            if (type == 0 && family == 0)
            {

                return this.cc.Pets.ToList();

            }
           else if (type !=0 && family != 0) 
            {
                return this.cc.Pets.Where(p=>p.PetTypeId==type && p.PetFamilyId==family).ToList();
            }
            else
            {
              if(type==0 && family != 0)
                {
                    return this.cc.Pets.ToList();
                }
              else if(type != 0 && family == 0)
                    return this.cc.Pets.ToList();

            }
            return this.cc.Pets.ToList();
           
        }
    }
}
