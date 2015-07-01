using Cinema.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.core.Interfaces
{
    public interface IUserRepository
    {
        void Add(User user);
        User Get(int id);
        void Modify(User user);
        void Modify(int id);
        void Check(User user);
    }
}
