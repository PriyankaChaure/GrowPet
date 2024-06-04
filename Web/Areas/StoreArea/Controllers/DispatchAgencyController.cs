using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Reposiratory.Store1;
using Web.StoreFilter;

namespace Web.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    [StoreAutho]
    public class DispatchAgencyController : Controller
    {
        IDispatchAgency ida;
        public DispatchAgencyController(IDispatchAgency ida)
        {
            this.ida = ida;
        }
        public IActionResult Index()
        {
            return View(this.ida.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(DispatchAgency rec)
        {
            if (ModelState.IsValid)
            {
                this.ida.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.ida.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(DispatchAgency rec)
        {
            if (ModelState.IsValid)
            {
                this.ida.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.ida.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
