using Microsoft.AspNetCore.Mvc;
using Reposiratory.Admin;
using Reposiratory.ViewModels;

namespace Web.Controllers
{
    public class ManageAdminController : Controller
    {
        IAdmin ia;
        public ManageAdminController(IAdmin ia)
        {
            this.ia = ia;
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
                    HttpContext.Session.SetString("AdminId",res.LoggedInId.ToString());
                    HttpContext.Session.SetString("AdminName", res.LoggedInName);
                    return RedirectToAction("Index", "AdminHome", new { Area = "AdminArea" });
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
        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("SignIn");
        }
    }
}
