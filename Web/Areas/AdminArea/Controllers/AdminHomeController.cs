using Microsoft.AspNetCore.Mvc;
using Reposiratory.Admin;
using Reposiratory.ViewModels.ChangePassword;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [CustAutho]
    public class AdminHomeController : Controller
    {
        IAdmin ia;
        IState ist;
        public AdminHomeController(IAdmin ia, IState ist)
        {
            this.ia = ia;
            this.ist = ist;
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
                var cid = Convert.ToInt64( HttpContext.Session.GetString("AdminId"));
                var res = this.ia.ChangePassword(rec, cid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult EditProfile()
        {
            var cid = Convert.ToInt64(HttpContext.Session.GetString("AdminId"));
            var rec = this.ia.GetById(cid);
            return View(rec);
        }

        [HttpPost]
        public IActionResult EditProfile(AdminVM rec)
        {
            if (ModelState.IsValid)
            {
                var cid = Convert.ToInt64(HttpContext.Session.GetString("AdminId"));
                var res = this.ia.EditProfile(rec, cid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }
        public IActionResult GetStateJson(Int64 id)
        {
            var rec = this.ist.GetStateByCountryId(id);
            return Json(rec.ToList());
        }
      
    }
}
