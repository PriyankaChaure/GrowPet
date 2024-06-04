using Core;
using Microsoft.AspNetCore.Mvc;
using Reposiratory.Admin;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [CustAutho]
    public class PetTypeController : Controller
    {
        IPetType ipt;
        public PetTypeController(IPetType ipt)
        {
            this.ipt = ipt;
        }
        public IActionResult Index()
        {
            return View(this.ipt.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PetType rec)
        {
            if (ModelState.IsValid)
            {
                this.ipt.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.ipt.GetById(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(PetType rec)
        {
            if (ModelState.IsValid)
            {
                this.ipt.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.ipt.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
