using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;

namespace Web.ViewComponents
{
    public class ProductIdVC:ViewComponent
    {
        IOrders io;
        public ProductIdVC(IOrders io)
        {
            this.io = io;
        }

        public IViewComponentResult Invoke(Int64 orderid)
        {

            var res = this.io.GetAllByOrderID1(orderid);
           
            return View(res);
        }
    }
}
