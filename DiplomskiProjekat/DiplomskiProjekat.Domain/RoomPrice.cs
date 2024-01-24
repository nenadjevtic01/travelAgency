using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class RoomPrice
    {
        public int RoomPriceId { get; set; }
        public int RoomId { get; set; }
        public decimal Price { get; set; }
        public DateTime ValidFrom { get; set; }

        public virtual Room Room { get; set; }
    }
}
