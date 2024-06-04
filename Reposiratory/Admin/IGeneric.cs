using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Admin
{
    public interface IGeneric<T> where T : class
    {
        List<T> GetAll();
        T GetById(Int64 id);
        void Add(T rec);
        void Edit(T rec);
        void Delete(Int64 id);
    }
}
