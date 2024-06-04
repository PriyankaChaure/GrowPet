using Core;
using Entities;
using Reposiratory.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Store1
{
    public class RepoDispatchAgency: RepoGeneric<DispatchAgency>, IDispatchAgency
    {
        ContextClass cc;
        public RepoDispatchAgency(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }

       
    }
}
