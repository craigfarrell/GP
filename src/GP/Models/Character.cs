using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GP.Models
{
    public class Character
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int CivilizationID { get; set; }
        public virtual Civilization Civilization { get; set; }
        public int Health { get; set; }
        public bool Alive { get; set; }
        public int Credits { get; set; }
        public int MilitaryRank { get; set; }
    }
}
