using Core;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Admin
{
    public class RepoPetType:RepoGeneric<PetType>,IPetType
    {
        ContextClass cc;
        public RepoPetType(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
