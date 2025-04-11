using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDb<T, K>
    {
        void Add(T item);
        void Update(T item);
        void Delete(K id);
        T GetById(K id);
        List<T> GetAll();
    }
}
