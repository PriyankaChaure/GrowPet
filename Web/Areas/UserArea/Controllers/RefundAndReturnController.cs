using Microsoft.AspNetCore.Mvc;
using Reposiratory.Users;
using Web.CustFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAutho]
    public class RefundAndReturnController : Controller
    {
        IReturn iru;
        IRefund irf;
        public RefundAndReturnController(IReturn iru, IRefund irf)
        {
            this.iru = iru;
            this.irf = irf;
        }
        public IActionResult Index()
        {
            var userid = Convert.ToInt64(HttpContext.Session.GetString("UserId"));
            return View(userid);
        }
        public IActionResult ReturnDetails(Int64 id)
        {
            ViewBag.ReturnId = id;
            var v = this.iru.GetReturnId(id);
            return View(v);
        }
        public IActionResult RefundDetails(Int64 id)
        {
            var v = this.iru.GetRefundDetails(id);
            return View(v);
        }
    }
}
