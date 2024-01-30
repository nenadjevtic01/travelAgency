

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class Accommodation
    {
        public int AccommodationId { get; set; }
        public string AccommodationName { get; set; }
        public decimal AccommodationStars { get; set; }
        public int DestinationId { get; set; }
        public int AccommodationTypeId { get; set; }

        public virtual Destination Destination { get; set; }
        public virtual AccommodationType AccommodationType { get; set;}
        public virtual ICollection<TripAccommodation> Trips { get; set; } = new List<TripAccommodation>();
        public virtual ICollection<RoomNumber> RoomsNumber { get; set; } = new List<RoomNumber>();
        public virtual ICollection<RoomTypePrice> RoomTypePrice { get; set; } = new List<RoomTypePrice>();
    }
}
