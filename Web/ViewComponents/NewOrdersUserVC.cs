using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;

namespace Web.ViewComponents
{
    
    public class NewOrdersUserVC:ViewComponent
    {
        IOrders io;
        public NewOrdersUserVC(IOrders Io)
        {
            this.io = Io;
        }
        public IViewComponentResult Invoke( Int64 userid)
        {
            var v = this.io.GetAllByUserId(userid);
            return View(v.ToList());
        }
    }
}
