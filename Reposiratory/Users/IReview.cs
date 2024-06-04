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
    public interface IReview:IGeneric<StoreReview>
    {
       List<Order>  GetAllByUserId(Int64 userid);
        List<StoreReviewVM> GetByStoreId(Int64 userid);
        List<StoreReviewVM> GetByPetId(Int64 userid);
        List<StoreReviewVM> GetByFoodId(Int64 userid);
        List<StoreReviewVM> GetByProductId(Int64 userid);
        ChangePasswordResultVM AddStoreReview(StoreReviewVM rec);
        ChangePasswordResultVM AddProductReview(StoreReviewVM rec,Int64 s);
        List<StoreReviewVM> GetByAllProductsId(long userid);
        List<StoreReview> GetByAllStoresId(long userid);
    }
}
