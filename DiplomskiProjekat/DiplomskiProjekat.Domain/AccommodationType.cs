using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class AccommodationType
    {
        public int AccommodationTypeId { get; set; }
        public string AccommodationTypeName { get; set; }

        public virtual ICollection<Accommodation> Accommodations { get; set; } = new List<Accommodation>();
    }
}
