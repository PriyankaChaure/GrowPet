using Core;
using Reposiratory.Admin;
using Reposiratory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Store1
{
    public interface IOrders: IGeneric<Order>
    {
        List<Order> GetAllByStoreId(Int64 storeid);
        List<CartVM> GetAllByOrderID1(Int64 orderid);
        List<CartVM> GetAllByOrderID2(Int64 orderid);
        List<CartVM> GetAllByOrderID3(Int64 orderid);
        List<Order> GetAllByUserId(Int64 userid);
        RepoResult AddReview(Int64 userid);
        RepoResult GetComplaint(Complaint rec);
        RepoResult GetReturn(Return rec);
        List<Payment> GetCollections(string f, string t,Int64 storeid);
        List<Order> GetPendings(string f, string t, Int64 storeid);
        List<ReturnVM> GetRefunds(string f, string t, Int64 storeid);
    }
}
