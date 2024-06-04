using Core;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Admin
{
    public class RepoCountry: RepoGeneric<Country>, ICountry
    {
        ContextClass cc;
        public RepoCountry(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
