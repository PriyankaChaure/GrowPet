using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class FoodShowVC:ViewComponent
    {
        IOrders io;
        public FoodShowVC(IOrders io)
        {
            this.io = io;
        }

        public IViewComponentResult Invoke(Int64 orderid)
        {
            var res = this.io.GetAllByOrderID2(orderid);
            return View(res);
        }
    }
}
