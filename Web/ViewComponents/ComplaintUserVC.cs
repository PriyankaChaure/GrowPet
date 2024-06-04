using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class ComplaintUserVC:ViewComponent
    {
        IComplaints ic;
        public ComplaintUserVC(IComplaints ic)
        {
            this.ic = ic;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var v = this.ic.GetAllByUserId(userid);
            return View(v.ToList());
        }
    }
}
