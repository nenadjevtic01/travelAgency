using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class AttractionImage
    {
        public int AttractionImageId { get; set; }
        public int AttractionId { get; set; }
        public string Src { get; set; }
        public string Alt { get; set; }

        public virtual Attraction Attraction { get; set; }

    }
}
