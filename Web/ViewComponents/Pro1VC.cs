using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class Pro1VC: ViewComponent
    {
        IReview ir;
        public Pro1VC(IReview ir)
        {
            this.ir = ir;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var v = this.ir.GetByPetId(userid);
            TempData["count"] = v.Count();
            return View(v);
        }
    }
}
