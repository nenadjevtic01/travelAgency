using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class UserFavorites
    {
        public int UserFavoritesId { get; set; }
        public int UserId { get; set; }
        public int DestinationId { get; set; }

        public virtual RegularUser User { get; set; }
        public virtual Destination Destination { get; set; }
    }
}
