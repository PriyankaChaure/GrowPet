using Core;
using Entities;
using Reposiratory.Admin;
using Reposiratory.Store1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Users
{
    public class RepoDispatchOrder : RepoGeneric<DispatchOrder>, IDispatchOrder
    {
        ContextClass cc;
        public RepoDispatchOrder(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<Order> GetAllByOrderId(long storeid)
        {

            var re = this.cc.Orders.Where(p => p.StoreId == storeid).ToList();
            if (re != null)
            {
                var v = from t in this.cc.Orders
                        join t1 in this.cc.DispatchOrders
                        on t.OrderId equals t1.OrderId
                        where t.StoreId == storeid
                        select t;
                return v.ToList();

            }
            else
                return re;



        }
        public List<Order> GetAllByOrderUserId(long userid)
        {

            var re = this.cc.Orders.Where(p => p.UserId == userid).ToList();
            if (re != null)
            {
                var v = from t in this.cc.Orders
                        join t1 in this.cc.DispatchOrders
                        on t.OrderId equals t1.OrderId
                        where t.UserId == userid
                        select t;
                return v.ToList();

            }
            else
                return re;



        }
    }
}
