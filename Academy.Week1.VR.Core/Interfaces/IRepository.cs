using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.VR.Core.Interfaces
{
    public interface IRepository<T>
    {
        List<T> FetchAll();
        T GetById(int id);
        bool Add(T item);
        bool Update(T item);
        bool Delete(T item);
    }
}
