using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class Trip : Entity
    {
        public int TripId { get; set; }
        public int TransportId { get; set; }
        public int ItineraryId { get; set; }
        public int DestinationId { get; set; }
        public int AgencyId { get; set; }
        public string TripName { get; set; }
        public string TripDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Availability { get; set; }
        public bool? IsActive { get; set; }

        public virtual Transport Transport { get; set; }
        public virtual Itinerary Itinerary { get; set; }
        public virtual Destination Destination { get; set; }
        public virtual Agency Agency { get; set; }

        public virtual ICollection<TripPrice> Prices { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public virtual ICollection<TripAccommodation> Accommodations { get; set; } = new List<TripAccommodation>();
        public virtual ICollection<TripAttraction> Attractions { get; set; } = new List<TripAttraction>();
    }
}
