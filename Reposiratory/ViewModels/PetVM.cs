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
    public class PetVM
    {
        public Int64 PetId { get; set; }
       
        public string PetName { get; set; }
       
        public Int64 Age { get; set; }
      
        public int Gender { get; set; }
       
        public Int64 PetTypeId { get; set; }
    
        public Int64 PetFamilyId { get; set; }

        public int ProductType { get; set; }
        public string PetDesc { get; set; }
       
        public string PhotoPath { get; set; }
        public IFormFile ActualFile { set; get; }
        public Int64 ProductId { get; set; }
      
        public decimal ProductPrice { get; set; }
        public Int64 StoreId { get; set; }
        public string PetTypeName { get; set; }
        public string PetFamilyName { get; set; }
    }
}
