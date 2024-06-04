using Microsoft.AspNetCore.Mvc;
using Reposiratory.Enums;
using Reposiratory.Users;

namespace Web.Controllers
{
    public class CartController : Controller
    {
        ICart ic;
        public CartController(ICart ic)
        {
            this.ic = ic;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddToCart(Int64 petid, Int64 storeid)
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserId"));
           
            if (userid == 0)
            {
                return RedirectToAction("SignIn", "ManageUser");
            }
            else
            {
                var res = this.ic.AddToCart(petid,userid,storeid);
                TempData["Message"] = res.Message;
                return RedirectToAction("PetCalled", "Home");
            }

        }
        public IActionResult GetMyCart()
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserId"));   
            return View(userid);
        }
        public IActionResult DeleteCart(Int64 cartid)
        {
            this.ic.Delete(cartid);
            return RedirectToAction("GetMyCart");
        }
        public IActionResult CheckOut(int PaymentMode)
        {
            if (PaymentMode == (int)PaymentEnum.CashOnDelivery)
            {
                return RedirectToAction("PlaceOrder", new { pmode = PaymentMode });
            }
            else
            {
                return RedirectToAction("PaymentGateway", new { pmode = PaymentMode });
            }
        }
        public IActionResult PlaceOrder(int pmode)
        { 
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserId"));
            var res = this.ic.PlaceOrder(userid, pmode);
            if (res.IsSuccess)
            {
                return View();
            }
            ViewBag.Message = res.Message;
            return RedirectToAction("GetMyCart");
        }
        public IActionResult AddToCartFood(Int64 foodid, Int64 storeid)
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserId"));

            if (userid == 0)
            {
                return RedirectToAction("SignIn", "ManageUser");
            }
            else
            {
                var res = this.ic.AddToCartFood(foodid, userid, storeid);
                  TempData["Message"] = res.Message;
                return RedirectToAction("FoodCalled", "Home");
            }

        }
        public IActionResult AddToCartProduct(Int64 productid, Int64 storeid)
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserId"));

            if (userid == 0)
            {
                return RedirectToAction("SignIn", "ManageUser");
            }
            else
            {
                var res = this.ic.AddToCartProduct(productid, userid, storeid);
                TempData["Message"] = res.Message;
                return RedirectToAction("ProductCalled", "Home");
            }

        }

        [HttpGet]
        public IActionResult PaymentGateway(int pmode)
        {
            ViewBag.PaymentMode = pmode;
            return View();
        }


        [HttpPost]
        [ActionName("PaymentGateway")]
        public IActionResult ProcessPaymentGateway(int pmode)
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserId"));
            var res = this.ic.PlaceOrder(userid, pmode);
            if (res.IsSuccess)
            {
                return View("PlaceOrder");
            }
            ViewBag.Message = res.Message;
            return RedirectToAction("GetMyCart");
        }
    }
}
