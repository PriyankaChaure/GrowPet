using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class Pro2VC: ViewComponent
    {
        IReview ir;
        public Pro2VC(IReview ir)
        {
            this.ir = ir;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var v = this.ir.GetByFoodId(userid);
            TempData["count"] = v.Count();
            return View(v);
        }
    }
}
