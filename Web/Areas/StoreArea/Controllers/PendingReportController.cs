using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;
using Web.StoreFilter;

namespace Web.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    [StoreAutho]
    public class PendingReportController : Controller
    {
        IOrders io;
        public PendingReportController(IOrders io)
        {
            this.io = io;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Pendings(string f, string t)
        {
            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreId"));
            var v = this.io.GetPendings(f, t, storeid);
            return View(v);
        }
    }
}
