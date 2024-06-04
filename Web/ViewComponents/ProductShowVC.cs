using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class ProductShowVC:ViewComponent
    {
        IOrders io;
        public ProductShowVC(IOrders io)
        {
            this.io = io;
        }

        public IViewComponentResult Invoke(Int64 orderid)
        {
            var res = this.io.GetAllByOrderID3(orderid);
            return View(res);
        }
    }
}
