using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.ViewModels
{
    public class PaymentGatewayVM
    {
        [Required(ErrorMessage = "Card No Require!")]
        public string CardNo { set; get; }
        [Required(ErrorMessage = "Expiry Date Require!")]
        public string ExpiryDate { set; get; }
        [Required(ErrorMessage = "CVV No Require!")]
        public string CVV { set; get; }
    }
}
