using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class ItineraryActivity
    {
        public int ItineraryActivityId { get; set; }
        public int ItineraryId { get; set; }
        public int Day { get; set; }
        public string Activity { get; set; }

        public virtual Itinerary Itinerary { get; set; }

    }
}
