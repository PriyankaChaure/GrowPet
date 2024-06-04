using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Reposiratory.Store1;
using Reposiratory.Users;
using Reposiratory.ViewModels;
using Web.StoreFilter;

namespace Web.Areas.StoreArea.Controllers
{

    [Area("StoreArea")]
    [StoreAutho]
    public class OrdersController : Controller
    {
        IOrders io;
        IDispatchAgency ida;
        IDispatchOrder ido;

        public OrdersController(IOrders io, IDispatchAgency ida,IDispatchOrder ido)
        {
            this.io = io;
            this.ida = ida;
            this.ido = ido;
        }
        public IActionResult Index()
        {
            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreId"));
           return View(this.io.GetAllByStoreId(storeid));
            //return View(this.io.GetAll());
        }
        public IActionResult NewOrder()
        {
            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreId"));
            return View(storeid);
        }
        public IActionResult ViewDetailsdispatchOrders(Int64 id)
        {
            ViewBag.orderid=id;
            var rec = this.io.GetById(id);
            return View(rec);  
        }
        [HttpGet]
        public IActionResult DispatchOrder(Int64 id)
        {
            ViewBag.DispatchAgencyId = new SelectList(this.ida.GetAll(), "DispatchAgencyId", "FullName");
            TempData["OrderId"]= id;
            return View();
        }
        [HttpPost]
        public IActionResult DispatchOrder(DispatchOrder rec,Int64 id)
        {
            ViewBag.DispatchAgencyId = new SelectList(this.ida.GetAll(), "DispatchAgencyId", "FullName");
            if (ModelState.IsValid)
            {
                rec.OrderId = Convert.ToInt64(id);
                rec.DispatchDate = DateTime.Now;
                this.ido.Add(rec);
                TempData["Message"] = "Your Order Dispatch Suucessfully!";
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        public IActionResult Viewdispatchdetails(Int64 id)
        {
            ViewBag.orderid=id;
            var rec = this.io.GetById(id);
            return View(rec);
        }
    }
}
