using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;
using Reposiratory.Users;
using Reposiratory.ViewModels;

namespace Web.Controllers
{
    public class ReviewController : Controller
    {
        IOrders io;
        IReview ir;
        public ReviewController(IOrders io, IReview ir)
        {
            this.io = io;
            this.ir = ir;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddReview()
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserId"));
            if (userid == 0)
            {
                return RedirectToAction("SignIn", "ManageUser");
            }
           
            else
            {
                return View();
            }
           
        }
        public IActionResult review()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StoreReview(StoreReviewVM rec)
        {
            if (ModelState.IsValid)
            {
               var v= this.ir.AddStoreReview(rec);
                TempData["Message"] = v.Message;
                return RedirectToAction("review");
            }
            return View(rec);
        }

        [HttpPost]
        public IActionResult ProductReview(StoreReviewVM rec)
        {
            Int64 s = rec.ProductId;
            if (ModelState.IsValid)
            {
                var v = this.ir.AddProductReview(rec,s);
                TempData["Message"] = v.Message;
                return RedirectToAction("review");
            }
            return View(rec);
        }

    }
}
