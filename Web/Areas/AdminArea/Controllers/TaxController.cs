using Microsoft.AspNetCore.Mvc;
using Reposiratory.Admin;
using Web.CustFilter;
using Core;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [CustAutho]
    public class TaxController : Controller
    {
        ITax it;
        public TaxController(ITax it)
        {
            this.it = it;
        }
        public IActionResult Index()
        {
            return View(this.it.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tax rec)
        {
            if (ModelState.IsValid)
            {
                this.it.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.it.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Tax rec)
        {
            if (ModelState.IsValid)
            {
                this.it.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.it.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
