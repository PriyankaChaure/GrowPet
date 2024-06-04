using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class store1VC:ViewComponent
    {
        IReview ir;
        public store1VC(IReview ir)
        {
            this.ir = ir;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
          var v=this.ir.GetByStoreId(userid);
           TempData["count"]=v.Count();
            return View(v);
        }
    }
}
