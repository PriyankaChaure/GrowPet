using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.ViewModels
{
    public class ReturnVM
    {
        public Int64 ReturnId { get; set; }
        public DateTime ReturnDate { get; set; }
        public string ReturnReason { get; set; }
        public Int64 OrderId { get; set; }

        public Int64 ProductId { get; set; }

        public DateTime Orderdate { get; set; }

        public Int64 UserId { get; set; }

        public Int64 StoreId { get; set; }
        public int ProductType { get; set; }
        public decimal ProductPrice { get; set; }
        public Int64 PetId { get; set; }
        public string PetName { get; set; }
        public Int64 FoodId { get; set; }
        public string FoodName { get; set; }
        public Int64 PetProductId { get; set; }
        public string ProductName { get; set; }
        public string Name { get; set; }
        public Int64 RefundId { get; set; }
        public DateTime RefundDate { get; set; }
      
        public decimal RefundAmount { get; set; }
    }
}
