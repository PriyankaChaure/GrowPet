using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Reposiratory.Admin;
using Reposiratory.Store1;
using Web.StoreFilter;

namespace Web.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    [StoreAutho]
    public class OfferController : Controller
    {
        IOffer io;
        IStore iso;
      
        public OfferController(IOffer io, IStore iso)
        {
            this.io = io;
            this.iso = iso;
        }
        public IActionResult Index()
        {
            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreId"));
            return View(this.io.GetAllByStoreId(storeid));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.StoreId = new SelectList(this.iso.GetAll(), "StoreId", "StoreName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Offer rec)
        {
            ViewBag.StoreId = new SelectList(this.iso.GetAll(), "StoreId", "StoreName",rec.StoreId);
            if (ModelState.IsValid)
            {
                this.io.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.io.GetById(id);
            ViewBag.StoreId = new SelectList(this.iso.GetAll(), "StoreId", "StoreName",rec.StoreId);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Offer rec)
        {
            ViewBag.StoreId = new SelectList(this.iso.GetAll(), "StoreId", "StoreName", rec.StoreId);
            if (ModelState.IsValid)
            {
                this.io.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.io.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
