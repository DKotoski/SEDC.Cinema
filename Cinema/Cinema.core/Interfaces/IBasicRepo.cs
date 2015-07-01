using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.core.Interfaces
{
    public interface IBasicRepo<T>
    {
        void Add(T entity);
        T Get(int id);
        void Modify(int id, T entity);
        void Modify(T entity, T entity);
    }
}
