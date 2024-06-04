using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;
using Reposiratory.Users;
using Web.CustFilter;
using Web.StoreFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAutho]
    public class ComplaintsController : Controller
    {
        IComplaints ic;
        IOrders io;
        ISolution iso;
        public ComplaintsController(IComplaints ic, IOrders io, ISolution iso)
        {
            this.ic = ic;
            this.io = io;
            this.iso = iso;
        }
        public IActionResult Index()
        {
            var userid = Convert.ToInt64(HttpContext.Session.GetString("UserId"));
            return View(userid);
        }
        public IActionResult ComplaintDetails(Int64 id)
        {
           // TempData["ComplaintID"] = id.ToString();
            ViewBag.ComplaintID=id;
            var v = this.ic.GetComplaintDetails(id);
            return View(v);
        }
        public IActionResult ViewSolution(Int64 id)
        {
            var rec = this.iso.GetSolutionByComplaintID(id);
            return View(rec);
        }
    }
}
