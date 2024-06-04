using Core;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Admin
{
    public  class RepoPetFamily:RepoGeneric<PetFamily>,IPetFamily
    {
        ContextClass cc;
        public RepoPetFamily(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
