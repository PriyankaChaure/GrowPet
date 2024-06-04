using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class RefundVC:ViewComponent
    {
        IRefund irf;
        public RefundVC(IRefund irf)
        {
            this.irf = irf;
        }
        public IViewComponentResult Invoke(Int64 storeid)
        {
            var v = this.irf.GetAllByRefund(storeid);
            return View(v.ToList());
        }
    }
}
