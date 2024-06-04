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
    public interface ISolution:IGeneric<Solution>
    {
        // List<Complaint> GetAllByComplaint(long storeid);
        List<ComplaintVM> GetAllByComplaint(long storeid);
        List<ComplaintVM> GetAllByUserComplaint(long userid);
        Solution GetSolutionByComplaintID(Int64 complaintid);
    }
}
