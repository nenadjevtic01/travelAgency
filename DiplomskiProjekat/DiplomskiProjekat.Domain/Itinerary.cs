using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class Itinerary
    {
        public int ItineraryId { get; set; }
        public string ItineraryName { get; set; }

        public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
        public virtual ICollection<ItineraryActivity> ItineraryActivities { get; set; } = new List<ItineraryActivity>();
    }
}
