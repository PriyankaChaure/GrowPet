using Core;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Admin
{
    public class RepoCategory: RepoGeneric<Category>, ICategory
    {
        ContextClass cc;
        public RepoCategory(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
