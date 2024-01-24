using DiplomskiProjekat.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.DataAccess.Configurations
{
    public class ReservationRoomConfiguration : EntityConfiguration<ReservationRoom>
    {

        protected override void ConfigureTableSpecifics(EntityTypeBuilder<ReservationRoom> builder)
        {
            builder.Property(x => x.ReservationRoomId).UseIdentityColumn(1, 1);
            builder.Property(x => x.ReservationId).IsRequired();
            builder.Property(x => x.RoomId).IsRequired();
            builder.Property(x => x.IsActive).IsRequired().HasDefaultValue(true);
        }
    }
}
