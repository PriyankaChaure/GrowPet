using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class ReturnUserVC:ViewComponent
    {
        IReturn iru;
        public ReturnUserVC(IReturn iru)
        {
            this.iru = iru;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var v = this.iru.GetAllByUserId(userid);
            return View(v.ToList());
        }
    }
}
