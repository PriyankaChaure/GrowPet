using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Reposiratory.Admin;
using Reposiratory.Store1;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        IPet ip;
        IPetFood ipf;
        IPetProduct ipp;
        public HomeController( IPet ip,IPetFood ipf,IPetProduct ipp)
        { 
            this.ip = ip;
            this.ipf= ipf;
            this.ipp= ipp;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PetCalled()
        {
            return View();
        }
        public IActionResult FoodCalled()
        {
            return View();
        }
        public IActionResult ProductCalled()
        {
            return View();
        }
        [HttpGet]
        public IActionResult searchByProperty(Int64 type, Int64 family)
        {
            var rec = this.ip.SearchByProperty(type, family);
            ViewBag.rec=rec;
            return View( "PetCalled",rec);
        }
        [HttpGet]
        public IActionResult searchByFoodProperty(string foodname)
        {
            var rec = this.ipf.SearchByFoodProperty(foodname);
            ViewBag.rec = rec;
            return View("FoodCalled", rec);
        }
        [HttpGet]
        public IActionResult searchByProductProperty(string productname)
        {
            var rec = this.ipp.SearchByProductProperty(productname);
            ViewBag.rec = rec;
            return View("ProductCalled", rec);
        }
       
    }
}
