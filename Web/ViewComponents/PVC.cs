using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class PVC: ViewComponent
    {
        IReview ir;
        public PVC(IReview ir)
        {
            this.ir = ir;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var v = this.ir.GetByAllProductsId(userid);
            return View(v);
        }
    }
}
