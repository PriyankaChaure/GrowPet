using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;

namespace Web.ViewComponents
{
    public class ProductId2VC:ViewComponent
    {
        IOrders io;
        public ProductId2VC(IOrders io)
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
