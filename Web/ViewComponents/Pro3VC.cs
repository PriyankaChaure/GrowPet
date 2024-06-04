using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class Pro3VC: ViewComponent
    {
        IReview ir;
        public Pro3VC(IReview ir)
        {
            this.ir = ir;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var v = this.ir.GetByProductId(userid);
            TempData["count"] = v.Count();
            return View(v);
        }
    }
}
