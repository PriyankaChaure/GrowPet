using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Admin
{
    public class RepoGeneric<T> : IGeneric<T> where T : class
    {
        DbContext dc;
        public RepoGeneric(DbContext dc)
        {
            this.dc = dc;
        }

        public void Add(T rec)
        {
            this.dc.Set<T>().Add(rec);
            this.dc.SaveChanges();
        }

        public void Delete(long id)
        {
            var rec = this.dc.Set<T>().Find(id);
            this.dc.Set<T>().Remove(rec);
            this.dc.SaveChanges();
        }

        public void Edit(T rec)
        {
            this.dc.Entry(rec).State = EntityState.Modified;
            this.dc.SaveChanges();
        }

        public List<T> GetAll()
        {
            return this.dc.Set<T>().ToList();
        }

        public T GetById(long id)
        {
            return this.dc.Set<T>().Find(id);
        }
    }
}
