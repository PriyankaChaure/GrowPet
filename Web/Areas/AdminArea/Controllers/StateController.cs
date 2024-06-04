using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Reposiratory.Admin;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [CustAutho]
    public class StateController : Controller
    {
        ICountry ic;
        IState ist;
        public StateController(ICountry ic, IState ist)
        {
            this.ic = ic;
            this.ist = ist;
        }
        public IActionResult Index()
        {
            return View(this.ist.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CountryId = new SelectList(this.ic.GetAll(), "CountryId", "CountryName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(State rec)
        {
            ViewBag.CountryId = new SelectList(this.ic.GetAll(), "CountryId", "CountryName",rec.CountryId);
            if (ModelState.IsValid)
            {
                this.ist.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.ist.GetById(id);
            ViewBag.CountryId = new SelectList(this.ic.GetAll(), "CountryId", "CountryName", rec.CountryId);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(State rec)
        {
            ViewBag.CountryId = new SelectList(this.ic.GetAll(), "CountryId", "CountryName", rec.CountryId);

            if (ModelState.IsValid)
            {
                this.ist.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.ist.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
