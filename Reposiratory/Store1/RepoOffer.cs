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
    public class RepoOffer: RepoGeneric<Offer>, IOffer
    {
        ContextClass cc;
        public RepoOffer(ContextClass cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<Offer> GetAllByStoreId(long storeid)
        {
            return this.cc.Offers.Where(p => p.StoreId == storeid).ToList();
        }
    }
}
