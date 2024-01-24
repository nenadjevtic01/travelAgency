using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CapitalCity { get; set; }
        public string Population { get; set; }
        public string TotalArea { get; set; }
        public string Currency { get; set; }
        public string Language { get; set; }
        public int ContinentId { get; set; }
        
        public virtual Safety Safety { get; set; }
        public virtual Visa VisaInfo { get; set; }
        public virtual Continent Continent { get; set; }

        public virtual ICollection<Destination> Destination { get; set; } = new List<Destination>();
    }
}
