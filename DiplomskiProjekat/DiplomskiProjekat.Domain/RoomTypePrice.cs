using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class RoomTypePrice
    {
        public int RoomTypePriceId { get; set; }
        public int AccommodationId { get; set; }
        public int RoomTypeId { get; set; }
        public decimal Price { get; set; }
        public DateTime ValidFrom { get; set; }

        public virtual Accommodation Accommodation { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual ICollection<ReservationRoom> RoomReservations { get; set; }=new List<ReservationRoom>();
    }
}
