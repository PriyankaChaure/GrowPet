using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.ViewModels
{
    public  class PetProductVM
    {
        public Int64 PetProductId { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public string PhotoPath { get; set; }
        public IFormFile ActualFile { set; get; }
        public Int64 ProductId { get; set; }
        public string ProductDesc { get; set; }
        public decimal ProductPrice { get; set; }
        public Int64 StoreId { get; set; }
        public int ProductType { get; set; }
    }
}
