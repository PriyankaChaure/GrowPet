using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class DispatchOrdersUserVC:ViewComponent
    {
        IDispatchOrder ido;
        public DispatchOrdersUserVC(IDispatchOrder ido)
        {
            this.ido = ido;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var v = this.ido.GetAllByOrderUserId(userid);
            return View(v.ToList());
           
        }
    }
}
