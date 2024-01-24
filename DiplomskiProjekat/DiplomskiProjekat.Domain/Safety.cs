using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class Safety
    {
        public int SafetyId { get; set; }
        public int CountryId { get; set; }
        public int SafetyLevel { get; set; }
        public string Advices { get; set; }

        public virtual Country Country { get; set; }
    }
}
