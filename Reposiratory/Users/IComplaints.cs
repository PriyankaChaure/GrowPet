using Core;
using Reposiratory.Admin;
using Reposiratory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Users
{
    public interface IComplaints:IGeneric<Complaint>
    {
        //   List<Complaint> GetAllByStoreId(Int64 storeid);
        List<ComplaintVM> GetAllByStoreId(Int64 storeid);
        List<ComplaintVM> GetAllByUserId(Int64 userid);
        ComplaintVM GetComplaintDetails(Int64 complaintid);
    }
}
