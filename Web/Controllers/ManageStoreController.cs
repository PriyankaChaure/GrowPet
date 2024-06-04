using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Reposiratory.Admin;

using Reposiratory.Store1;
using Reposiratory.ViewModels;

namespace Web.Controllers
{
    public class ManageStoreController : Controller
    {
        IStore ia;
      
        ICity ic;
        IState ist;
        ICountry ico;
        public ManageStoreController(IStore ia,ICity ic,IState ist, ICountry ico)
        {
            this.ia = ia;
            this.ic = ic;
            this.ist = ist;
            this.ico = ico;
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(LoginVM rec)
        {
            if (ModelState.IsValid)
            {
                var res = this.ia.Login(rec);
                if (res.IsSuccess)
                {
                    HttpContext.Session.SetString("StoreId", res.LoggedInId.ToString());
                    HttpContext.Session.SetString("StoreName", res.LoggedInName);
                    return RedirectToAction("Index", "StoreHome", new { Area = "StoreArea" });
                }
                else
                {
                    ModelState.AddModelError("", res.Message);
                    return View(rec);
                }
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            ViewBag.CityId = new SelectList(this.ic.GetAll(), "CityId", "CityName");
            ViewBag.StateId = new SelectList(this.ist.GetAll(), "StateId", "StateName");
            ViewBag.CountryId = new SelectList(this.ico.GetAll(), "CountryId", "CountryName");
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(StoreAddVM rec)
        {
            ViewBag.CityId = new SelectList(this.ic.GetAll(), "CityId", "CityName");
            ViewBag.StateId = new SelectList(this.ist.GetAll(), "StateId", "StateName");
            ViewBag.CountryId = new SelectList(this.ico.GetAll(), "CountryId", "CountryName");
            if (ModelState.IsValid)
            {
                this.ia.SignUp(rec);
                return RedirectToAction("SignIn");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult SignOut()
        {  
            HttpContext.Session.Clear();
            return RedirectToAction("SignIn");
        }
        public IActionResult GetStateJson(Int64 id)
        {
            var rec = this.ist.GetStateByCountryId(id);
            return Json(rec.ToList());
        }
        public IActionResult GetCityJson(Int64 id)
        {
            var rec = this.ic.GetCityByStateId(id);
            return Json(rec.ToList());
        }
    }
}
