using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class AttractionCategory
    {
        public int AttractionCategoryId { get; set; }
        public string AttractionCategoryName { get; set; }

        public virtual ICollection<Attraction> Attractions { get; set; } = new List<Attraction>();
    }
}
