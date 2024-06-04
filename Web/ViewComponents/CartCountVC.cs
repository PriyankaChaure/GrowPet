using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class CartCountVC:ViewComponent
    {
        ICart ic;
        public CartCountVC(ICart ic)
        {
            this.ic = ic;
        }

        public IViewComponentResult Invoke(Int64 userid)
        {
            var cnt = this.ic.GetCartCount(userid);
            return View(cnt);
        }
    }
}
