using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;
using Reposiratory.Users;
using Reposiratory.ViewModels;
using Web.StoreFilter;

namespace Web.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    [StoreAutho]
    public class ReturnAndRefundController : Controller
    {
        IReturn iru;
        IRefund irf;
        public ReturnAndRefundController(IReturn iru,IRefund irf)
        {
            this.iru = iru;
            this.irf = irf;
        }
        public IActionResult Index()
        {
            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreId"));
            return View(storeid);
        }
        [HttpGet]
        public IActionResult ReturnDetails(Int64 id)
        {
            ViewBag.ReturnId=id;
            var v= this.iru.GetReturnId(id);
            return View(v);
        }
        [HttpPost]
        public IActionResult ReturnDetails( ReturnVM rec,Int64 id)
        {
            if (ModelState.IsValid)
            {
                var v= this.iru.AddReturns(rec);
                TempData["Message"] =v.Message ;
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        public IActionResult RefundDetails(Int64 id)
        {
            var v = this.iru.GetRefundDetails(id);
            return View(v);
        }
    }
}
