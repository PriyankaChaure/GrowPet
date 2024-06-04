using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;

namespace Web.ViewComponents
{
    public class SolutionVC:ViewComponent
    {
        ISolution iso;
        public SolutionVC(ISolution iso)
        {
            this.iso = iso;
        }
        public IViewComponentResult Invoke(Int64 storeid)
        {
            var v = this.iso.GetAllByComplaint(storeid);
            return View(v.ToList());
        }
    }
}
