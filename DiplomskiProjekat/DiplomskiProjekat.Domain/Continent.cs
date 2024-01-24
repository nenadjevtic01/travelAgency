using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class Continent
    {
        public int ContinentId { get; set; }
        public string ContinentName { get; set; }

        public virtual ICollection<Country> Countries { get; set; }
    }
}
