using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class RoomNumber
    {
        public int RoomNumberId { get; set; }
        public int AccommodationId { get; set; }
        public int RoomTypeId { get; set; }
        public int NumberOf { get; set; }

        public virtual Accommodation Accommodation { get; set; }
        public virtual RoomType RoomType { get; set; }
    }
}
