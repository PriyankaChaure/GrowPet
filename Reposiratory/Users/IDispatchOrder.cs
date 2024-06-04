using Core;
using Reposiratory.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Users
{
    public interface IDispatchOrder: IGeneric<DispatchOrder>
    {
        List<Order> GetAllByOrderId(Int64 storeid);
        List<Order> GetAllByOrderUserId(long userid);
    }
}
