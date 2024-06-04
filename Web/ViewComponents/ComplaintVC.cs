using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class ComplaintVC:ViewComponent
    {
        IComplaints ic;
        public ComplaintVC(IComplaints ic)
        {
            this.ic = ic;
        }
        public IViewComponentResult Invoke(Int64 storeid)
        {
            var v = this.ic.GetAllByStoreId(storeid);
            return View(v.ToList());
        }
    }
}
