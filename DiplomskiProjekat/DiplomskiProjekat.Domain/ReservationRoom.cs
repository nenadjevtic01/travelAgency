using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class ReservationRoom : Entity
    {
        public int ReservationRoomId { get; set; }
        public int ReservationId { get; set; }
        public int AccommodationId { get; set; }
        public int RoomTypePriceId { get; set; }
        public int Quantity { get; set; }
        public bool? IsActive { get; set; }

        public virtual Accommodation Accommodation { get; set; }
        public virtual RoomTypePrice RoomTypePrice { get; set; }
        public virtual Reservation Reservation { get; set; }

    }
}
