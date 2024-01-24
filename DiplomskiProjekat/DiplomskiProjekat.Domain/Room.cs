using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class Room
    {
        public int RoomId { get; set; }
        public int AccommodationId { get; set; }
        public int RoomTypeId { get; set; }
        public bool AC { get; set; }
        public bool Balcony { get; set; }

        public virtual Accommodation Accommodation { get; set; }
        public virtual RoomType RoomType { get; set; }

        public virtual ICollection<ReservationRoom> Reservations { get; set; } = new List<ReservationRoom>();
        public virtual ICollection<RoomPrice> Prices { get; set; } = new List<RoomPrice>();
    }
}
