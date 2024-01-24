using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public int CountryId { get; set; }
        public string DestinationName { get; set; }
        public string DestinationDescription { get; set; }
        public bool? IsActive { get; set; }

        public virtual Country Country { get; set; }
        public virtual Climate Climate { get; set; }
        public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
        public virtual ICollection<DestinationImage> Images { get; set; } = new List<DestinationImage>();
        public virtual ICollection<Accommodation> Accommodations { get; set;} = new List<Accommodation>();
        public virtual ICollection<Attraction> Attractions { get; set; } = new List<Attraction>();

        public virtual ICollection<UserFavorites> UserFavorites { get; set; } = new List<UserFavorites>();
    }
}
