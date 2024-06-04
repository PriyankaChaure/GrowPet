using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;

namespace Web.ViewComponents
{
    
    public class NewOrdersVC:ViewComponent
    {
        IOrders io;
        public NewOrdersVC(IOrders Io)
        {
            this.io = Io;
        }
        public IViewComponentResult Invoke( Int64 storeid)
        {
            var v = this.io.GetAllByStoreId(storeid);
            return View(v.ToList());
        }
    }
}
