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
    public class ReservationConfiguration : EntityConfiguration<Reservation>
    {
        protected override void ConfigureTableSpecifics(EntityTypeBuilder<Reservation> builder)
        {
            builder.Property(x => x.ReservationId).UseIdentityColumn(1, 1);
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.TripId).IsRequired();
            builder.Property(x => x.NumberOfAdults).IsRequired();
            builder.Property(x => x.NumberOfChildren).IsRequired();
            builder.Property(x => x.CheckInDate).IsRequired().HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.CheckOutDate).IsRequired().HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.TotalPrice).IsRequired().HasPrecision(6, 2);
            builder.Property(x => x.IsActive).IsRequired().HasDefaultValue(true);

            builder
                .HasMany(x => x.Rooms)
                .WithOne(x => x.Reservation)
                .HasForeignKey(x => x.ReservationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
