using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class PetShowVC:ViewComponent
    {
        IOrders io;
        public PetShowVC(IOrders io)
        {
            this.io = io;
        }

        public IViewComponentResult Invoke(Int64 orderid)
        {
            var res = this.io.GetAllByOrderID1(orderid);
            //List<decimal> Amount = res.Select(p => p.Price * p.Quantity).ToList();
            //decimal amt = Amount.Sum();
            //TempData["totalpet"] = amt;
            return View(res);
        }
    }
}
