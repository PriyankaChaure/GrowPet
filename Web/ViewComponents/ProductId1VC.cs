using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;

namespace Web.ViewComponents
{
    public class ProductId1VC:ViewComponent
    {
        IOrders io;
        public ProductId1VC(IOrders io)
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
