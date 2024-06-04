using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class SolutionUserVC:ViewComponent
    {
        ISolution iso;
        public SolutionUserVC(ISolution iso)
        {
            this.iso = iso;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var v = this.iso.GetAllByUserComplaint(userid);
            return View(v.ToList());
        }
    }
}
