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
    public class TripConfiguration : EntityConfiguration<Trip>
    {

        protected override void ConfigureTableSpecifics(EntityTypeBuilder<Trip> builder)
        {
            builder.Property(x => x.TripId).UseIdentityColumn(1, 1);
            builder.Property(x => x.TransportId).IsRequired();
            builder.Property(x => x.ItineraryId).IsRequired();
            builder.Property(x => x.DestinationId).IsRequired();
            builder.Property(x => x.AgencyId).IsRequired();
            builder.Property(x => x.TripName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.TripDescription).IsRequired().HasMaxLength(130);
            builder.Property(x => x.StartDate).IsRequired().HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.EndDate).IsRequired().HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.Availability).IsRequired();
            builder.Property(x => x.IsActive).IsRequired().HasDefaultValue(true);

            builder
                .HasMany(x => x.Prices)
                .WithOne(x => x.Trip)
                .HasForeignKey(x => x.TripId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(x => x.Reservations)
                .WithOne(x => x.Trip)
                .HasForeignKey(x => x.TripId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(x => x.Accommodations)
                .WithOne(x => x.Trip)
                .HasForeignKey(x => x.TripId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(x => x.Attractions)
                .WithOne(x => x.Trip)
                .HasForeignKey(x => x.TripId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
