using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class DispatchOrdersVC:ViewComponent
    {
        IDispatchOrder ido;
        public DispatchOrdersVC(IDispatchOrder ido)
        {
            this.ido = ido;
        }
        public IViewComponentResult Invoke(Int64 storeid)
        {
            var v = this.ido.GetAllByOrderId(storeid);
            return View(v.ToList());
           
        }
    }
}
