using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Reposiratory.Admin;
using Reposiratory.Store1;
using Reposiratory.Users;
using Reposiratory.ViewModels.ChangePassword;
using Web.CustFilter;
using Web.StoreFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAutho]
    public class UserHomeController : Controller
    {
        IUser iu;
        ICity ic;
        IState ist;
        ICountry ico;
        public UserHomeController(IUser iu, ICity ic, IState ist, ICountry ico)
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
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordVM rec)
        {
            if (ModelState.IsValid)
            {
                var cid = Convert.ToInt64(HttpContext.Session.GetString("UserId"));
                var res = this.iu.ChangePassword(rec, cid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult EditProfile()
        {
            ViewBag.CityId = new SelectList(this.ic.GetAll(), "CityId", "CityName");
            ViewBag.StateId = new SelectList(this.ist.GetAll(), "StateId", "StateName");
            ViewBag.CountryId = new SelectList(this.ico.GetAll(), "CountryId", "CountryName");
            var cid = Convert.ToInt64(HttpContext.Session.GetString("UserId"));
            var rec = this.iu.GetById(cid);
            return View(rec);
        }

        [HttpPost]
        public IActionResult EditProfile(UserVM rec)
        {
            ViewBag.CityId = new SelectList(this.ic.GetAll(), "CityId", "CityName");
            ViewBag.StateId = new SelectList(this.ist.GetAll(), "StateId", "StateName");
            ViewBag.CountryId = new SelectList(this.ico.GetAll(), "CountryId", "CountryName");
            if (ModelState.IsValid)
            {
                var cid = Convert.ToInt64(HttpContext.Session.GetString("UserId"));
                var res = this.iu.EditProfile(rec, cid);
                ViewBag.Message = res.Message;
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
    }
}
