using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP.Models
{
    public class Civilization
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Planet> Planets { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
    }
}
