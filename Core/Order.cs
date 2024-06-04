using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TblOrder")]
    public  class Order
    {
        [Key]
        public Int64 OrderId { get; set; }
        [Required(ErrorMessage = "Order Date Require!")]
        public DateTime Orderdate { get; set; }
        [ForeignKey("User")]
        public Int64 UserId { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("Store")]
        public Int64 StoreId { get; set; }
        public virtual Store Store { get; set; }
        [Required(ErrorMessage = "IsPaid Require!")]
        public bool IsPaid {  get; set; }
        public virtual List<OrderDet> OrderDets { get; set; }
        public virtual List<Complaint> Complaints { get; set; } 
        public virtual List<Return> Returns { get; set; }
       
        public virtual List<DispatchOrder> DispatchOrders { get; set; }
        public virtual List<OrderTax> OrderTaxes { get; set; }
        public virtual List<Payment> Payments { get; set; }
        public Order()
        {
            OrderDets = new List<OrderDet>();
            Payments= new List<Payment>();  
        }
    }
}
