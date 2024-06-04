using Core;
using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;
using Reposiratory.Users;
using Web.CustFilter;
using Web.StoreFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAutho]
    public class OrdersController : Controller
    {
        IOrders io;
        IDispatchOrder ido;
        public OrdersController(IOrders io, IDispatchOrder ido)
        {
            this.io = io;
            this.ido = ido;
        }
        public IActionResult Index()
        {
            var userid = Convert.ToInt64(HttpContext.Session.GetString("UserId"));
            return View(this.io.GetAllByUserId(userid));
         
        }
        public IActionResult ViewDetails(Int64 id)
        {
            ViewBag.orderid = id;
            var rec = this.io.GetById(id);
            return View(rec);
        }
        public IActionResult Viewdispatch(Int64 id)
        {
            ViewBag.orderid = id;
            var rec = this.io.GetById(id);
            return View(rec);
        }
        [HttpGet]
        public IActionResult RaiseComplaint(Int64 id)
        {
            TempData["OrderId"] = id;
            return View();
        }
        [HttpPost]
        public IActionResult RaiseComplaint(Complaint rec,Int64 id)
        {
          
          rec.OrderId = id;
            var v = this.io.GetComplaint(rec);
            TempData["Message"] = v.Message;
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Return(Int64 id)
        {
            TempData["OrderId"] = id;
            return View();
        }
        [HttpPost]
        public IActionResult Return(Return rec, Int64 id)
        {

            rec.OrderId = id;
            var v = this.io.GetReturn(rec);
            TempData["Message"] = v.Message;
            return RedirectToAction("Index");
        }


    }
}
