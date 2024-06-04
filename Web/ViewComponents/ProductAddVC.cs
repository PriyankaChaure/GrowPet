using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class ProductAddVC: ViewComponent
    {
        ICart ic;
        public ProductAddVC(ICart ic)
        {
            this.ic = ic;
        }

        public IViewComponentResult Invoke(Int64 userid)
        {
            var res = this.ic.GetAllByUserID3(userid);
           
            List<decimal> Amount = res.Select(p => p.Price * p.Quantity).ToList();
            decimal amt = Amount.Sum();
            TempData["totalproduct"] = amt;
            return View(res); 
        }
    }
}
