using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.core.Entities
{
    public class Actor:BasicEntity
    {
        public string FullName { get; set; }
        public ICollection<Movie> ActedIn { get; set; }
    }
}
