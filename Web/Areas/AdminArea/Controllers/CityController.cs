using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Reposiratory.Admin;
using Reposiratory.ViewModels;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{

    [Area("AdminArea")]
    [CustAutho]
    public class CityController : Controller
    {
        ICity ic;
        IState ist;
        ICountry ico;
        public CityController(ICity ic, IState ist, ICountry ico)
        {
            this.ic = ic;
            this.ist = ist;
            this.ico = ico;
        }
        public IActionResult Index()
        {
            return View(this.ic.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CountryId = new SelectList(this.ico.GetAll(), "CountryId", "CountryName");
            ViewBag.StateId = new SelectList(this.ist.GetAll(), "StateId", "StateName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(CountryVM rec)
        {
            ViewBag.CountryId = new SelectList(this.ico.GetAll(), "CountryId", "CountryName");
            ViewBag.StateId = new SelectList(this.ist.GetAll(), "StateId", "StateName");
            if (ModelState.IsValid)
            {
                this.ic.AddCity(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.ic.GetById(id);
            ViewBag.StateId = new SelectList(this.ist.GetAll(), "StateId", "StateName", rec.StateId);
            ViewBag.CountryId = new SelectList(this.ico.GetAll(), "CountryId", "CountryName", rec.State.CountryId);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(City rec)
        {
            ViewBag.CountryId = new SelectList(this.ico.GetAll(), "CountryId", "CountryName", rec.State.CountryId);
            ViewBag.StateId = new SelectList(this.ist.GetAll(), "StateId", "StateName", rec.StateId) ;
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
