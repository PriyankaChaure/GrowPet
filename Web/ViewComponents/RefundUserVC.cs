using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class RefundUserVC:ViewComponent
    {
        IRefund irf;
        public RefundUserVC(IRefund irf)
        {
            this.irf = irf;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var v = this.irf.GetAllByUserRefund(userid);
            return View(v.ToList());
        }
    }
}
