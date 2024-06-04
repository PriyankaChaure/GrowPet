using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class ProductReviewVC:ViewComponent
    {
        IReview ir;
        public ProductReviewVC(IReview ir)
        {
            this.ir = ir;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            TempData["userid"] = userid;
            return View();
        }
    }
}
