using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;
using Web.StoreFilter;

namespace Web.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    [StoreAutho]
    public class RefundReportController : Controller
    {
        IOrders io;
        public RefundReportController(IOrders io)
        {
            this.io = io;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Refunds(string f, string t)
        {
            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreId"));
            var v = this.io.GetRefunds(f, t, storeid);
            return View(v);
        }
    }
}
