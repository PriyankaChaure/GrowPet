using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Reposiratory.ViewModels
{
    public class StoreReviewVM
    {
        public Int64 StoreReviewId { get; set; }
        public string Review { get; set; }
        public Int64 StoreId { get; set; }
        public int Rating { get; set; }
        public Int64 UserId { get; set; }
        public Int64 ProductId { get; set; }
        public int ProductType { get; set; }
        public decimal ProductPrice { get; set; }
        public Int64 PetId { get; set; }
        public string PetName { get; set; }
        public Int64 FoodId { get; set; }
        public string FoodName { get; set; }
        public Int64 PetProductId { get; set; }
        public string ProductName { get; set; }
        public string StoreName { get; set; }
        public string ReviewDesc { get; set; }
        public IFormFile ActualFile { set; get; }
        public string PhotoPath { get; set; }
        public string PhotoPath1 { get; set; }
        public string PhotoPath2 { get; set; }
        public string PhotoPath3 { get; set; }
        public string FullName {  get; set; }
    }
}
