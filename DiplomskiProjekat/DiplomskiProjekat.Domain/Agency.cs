using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class Agency
    {
        public int AgencyId { get; set; }
        public string AgencyName { get; set;}
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<AgencyEmployee> Employees { get; set; } = new List<AgencyEmployee>();
        public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
    }
}
