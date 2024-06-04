using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class ReturnVC:ViewComponent
    {
        IReturn iru;
        public ReturnVC(IReturn iru)
        {
            this.iru = iru;
        }
        public IViewComponentResult Invoke(Int64 storeid)
        {
            var v = this.iru.GetAllByStoreId(storeid);
            return View(v.ToList());
        }
    }
}
