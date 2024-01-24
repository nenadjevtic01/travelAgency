using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class TripAttraction
    {
        public int TripId { get; set; }
        public int AttractionId { get; set; }
        
        public virtual Attraction Attraction { get; set; }
        public virtual Trip Trip { get; set; }
    }
}
