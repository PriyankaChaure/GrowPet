using Core;
using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;
using Reposiratory.Users;
using Web.StoreFilter;

namespace Web.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    [StoreAutho]
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
            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreId"));
            return View(storeid);

        }
       

        public IActionResult GiveSolution(Int64 id)
        {
            TempData["ComplaintID"] = id;
            return View();
        }
        [HttpPost]
        public IActionResult GiveSolution(Solution rec)
        {
            if (ModelState.IsValid)
            {
               this.iso.Add(rec);
                TempData["Message"] = "Your Solution Added Successfully!";
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult ViewSolution(Int64 id)
        {
            //TempData["ComplaintId"] = id;
            var rec = this.iso.GetSolutionByComplaintID(id);
            return View(rec);
        }
    }
}
