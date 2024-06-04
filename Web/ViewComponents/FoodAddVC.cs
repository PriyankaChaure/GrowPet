using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class FoodAddVC:ViewComponent
    {
        ICart ic;
        public FoodAddVC(ICart ic)
        {
            this.ic = ic;
        }

        public IViewComponentResult Invoke(Int64 userid)
        {
            var res = this.ic.GetAllByUserID2(userid);
            List<decimal> Amount = res.Select(p => p.Price * p.Quantity).ToList();
            decimal amt = Amount.Sum();
            TempData["totalfood"] = amt;
            return View(res);
        }
    }
}
