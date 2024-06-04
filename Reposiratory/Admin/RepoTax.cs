using Core;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Admin
{
    public class RepoTax:RepoGeneric<Tax>, ITax
    {
        ContextClass cc;
        public RepoTax(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
