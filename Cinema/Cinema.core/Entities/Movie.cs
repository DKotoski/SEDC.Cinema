using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.core.Entities
{
    public class Movie:BasicEntity
    {
        public string Name { get; set; }
        public int LengthInMin{ get; set; }
        public Genre Genre { get; set; }
        public ICollection<Actor> Actors { get; set; }
    }
}
