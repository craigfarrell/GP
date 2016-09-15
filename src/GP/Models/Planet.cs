using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP.Models
{
    public class Planet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CivilizationID { get; set; }
        public virtual Civilization Civilization { get; set; }
    }
}
