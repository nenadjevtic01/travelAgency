using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class Transport
    {
        public int TransportId { get; set; }
        public string TransportName { get; set; }

        public virtual ICollection<Trip> TripList { get; set; } = new List<Trip>();
    }
}
