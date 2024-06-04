using Core;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.ViewModels
{
    public class CartVM
    {
        public Int64 CartId { get; set; }
       
        public DateTime CartDate { get; set; }
      
        public Int64 Quantity { get; set; }
      
        public decimal Price { get; set; }
        public Int64 UserId { get; set; }
        public Int64 ProductId { get; set; }
       
        public Int64 StoreId { get; set; }
        public Int64 PetId { get; set; }
      
        public string PetName { get; set; }
       
        public Int64 Age { get; set; }
      
        public int Gender { get; set; }
        public Int64 PetTypeId { get; set; }
        public string PetTypeName { get; set; }
        public Int64 PetFamilyId { get; set; }
        public string PetFamilyName { get; set; }
        public IFormFile ActualFile { set; get; }
     
        public string PhotoPath { get; set; }

        public Int64 FoodId { get; set; }
       
        public string FoodName { get; set; }
     
        public string MfgName { get; set; }
      
        public string FoodDesc { get; set; }
        public int GoodFoodAccordingToPetAge { get; set; }

       
        public Int64 PetProductId { get; set; }
       
        public string ProductName { get; set; }
     
        public string ProductDesc { get; set; }
        public Int64 OrderId { get; set; }
        public Int64 OrderDetID { get; set; }
    }
}
