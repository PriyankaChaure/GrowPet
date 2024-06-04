using Core;
using Microsoft.AspNetCore.Mvc;
using Reposiratory.Admin;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [CustAutho]
    public class PetFamilyController : Controller
    {
        IPetFamily ipf;
        public PetFamilyController(IPetFamily ipf)
        {
            this.ipf = ipf;
        }
        public IActionResult Index()
        {
            return View(this.ipf.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PetFamily rec)
        {
            if (ModelState.IsValid)
            {
                this.ipf.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.ipf.GetById(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(PetFamily rec)
        {
            if (ModelState.IsValid)
            {
                this.ipf.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.ipf.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
