using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;
using Reposiratory.Users;
using Microsoft.AspNetCore.Mvc.Rendering;
using Reposiratory.Admin;
using Reposiratory.ViewModels;

namespace Web.Controllers
{
    public class ManageUserController : Controller
    {
        IUser iu;
        ICity ic;
        IState ist;
        ICountry ico;
        public ManageUserController(IUser iu, ICity ic, IState ist, ICountry ico)
        {
            this.iu = iu;
            this.ic = ic;
            this.ist = ist;
            this.ico = ico;
        }
        public IActionResult Index()
        {
            return View();
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
                var res = this.iu.Login(rec);
                if (res.IsSuccess)
                {
                    HttpContext.Session.SetString("UserId", res.LoggedInId.ToString());
                    HttpContext.Session.SetString("FullName", res.LoggedInName);
                    return RedirectToAction("Index","Home"/*, "UserHome", new { Area = "UserArea" }*/);
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
        public IActionResult SignUp(UserAddVM rec)
        {
            ViewBag.CityId = new SelectList(this.ic.GetAll(), "CityId", "CityName");
            ViewBag.StateId = new SelectList(this.ist.GetAll(), "StateId", "StateName");
            ViewBag.CountryId = new SelectList(this.ico.GetAll(), "CountryId", "CountryName");
            if (ModelState.IsValid)
            {
                this.iu.SignUp(rec);
                return RedirectToAction("SignIn");
            }
            return View(rec);
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
        [HttpGet]
        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("SignIn");
        }
    }
}
