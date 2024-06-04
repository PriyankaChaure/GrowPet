using Core;
using Reposiratory.Admin;
using Reposiratory.ViewModels;
using Reposiratory.ViewModels.ChangePassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Users
{
    public  interface ICart:IGeneric<Cart>
    {
        ChangePasswordResultVM AddToCart(Int64 petid, Int64 userid,Int64 storeid);
        ChangePasswordResultVM AddToCartFood(Int64 Foodid, Int64 userid, Int64 storeid);
        ChangePasswordResultVM AddToCartProduct(Int64 productid, Int64 userid, Int64 storeid);
        int GetCartCount(Int64 userid);
        List<Cart> GetAllByUserID(Int64 userid);
        List<CartVM> GetAllByUserID1(Int64 userid);
       
        List<CartVM> GetAllByUserID2(Int64 userid);
        List<CartVM> GetAllByUserID3(Int64 userid);
        ChangePasswordResultVM PlaceOrder(Int64 userid, int pmode);
    }
}
