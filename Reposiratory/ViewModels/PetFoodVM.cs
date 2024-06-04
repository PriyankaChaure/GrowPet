using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.ViewModels
{
    public class PetFoodVM
    {
        public Int64 FoodId { get; set; }
        public string FoodName { get; set; }
        public string MfgName { get; set; }
        public string FoodDesc { get; set; }
        public string PhotoPath { get; set; }
        public IFormFile ActualFile { set; get; }
        public Int64 ProductId { get; set; }
        public int ProductType { get; set; }
        public decimal ProductPrice { get; set; }
        public Int64 StoreId { get; set; }
        public int GoodFoodAccordingToPetAge { get; set; }
    }
}
