using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.core.Entities
{
    class User:BasicEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; private set; }
    }
}
