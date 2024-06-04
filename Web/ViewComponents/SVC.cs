using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class SVC: ViewComponent
    {
        IReview ir;
        public SVC(IReview ir)
        {
            this.ir = ir;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var v = this.ir.GetByAllStoresId(userid);
            return View(v);
        }
    }
}
