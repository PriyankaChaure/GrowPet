using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class PetAddVC:ViewComponent
    {
        ICart ic;
        public PetAddVC(ICart ic)
        {
            this.ic = ic;
        }

        public IViewComponentResult Invoke(Int64 userid)
        {
            
            var res = this.ic.GetAllByUserID1(userid);
            List<decimal> Amount = res.Select(p => p.Price * p.Quantity).ToList();
            decimal amt = Amount.Sum();
            TempData["totalpet"] = amt;
            return View(res);
        }
    }
}
