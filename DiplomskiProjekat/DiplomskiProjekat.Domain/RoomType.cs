using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class RoomType
    {
        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }

        public virtual ICollection<RoomNumber> AccommodationRoomsNumber { get; set;} = new List<RoomNumber>();
        public virtual ICollection<RoomTypePrice> RoomTypePrice { get; set;} = new List<RoomTypePrice>();

    }
}
