using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class Reservation : Entity
    {
        public int ReservationId { get; set; }
        public int UserId { get; set; }
        public int TripId { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }
        public bool? IsActive { get; set; }

        public virtual RegularUser User { get; set; }
        public virtual Trip Trip { get; set; }

        public virtual ICollection<ReservationRoom> Rooms { get; set; } = new List<ReservationRoom>();
    }
}
