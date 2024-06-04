using Core;
using Microsoft.AspNetCore.Mvc;
using Reposiratory.Admin;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{

    [Area("AdminArea")]
    [CustAutho]
    public class CategoryController : Controller
    {
        ICategory ic;
        public CategoryController(ICategory ic)
        {
            this.ic = ic;
        }
        public IActionResult Index()
        {
            return View(this.ic.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category rec)
        {
            if (ModelState.IsValid)
            {
                this.ic.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.ic.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Category rec)
        {
            if (ModelState.IsValid)
            {
                this.ic.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.ic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
