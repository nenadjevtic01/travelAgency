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
    public class AccommodationConfiguration : IEntityTypeConfiguration<Accommodation>
    {
        public void Configure(EntityTypeBuilder<Accommodation> builder)
        {
            builder.Property(x=>x.AccommodationId).UseIdentityColumn(1,1);
            builder.Property(x => x.AccommodationName).IsRequired().HasMaxLength(20);
            builder.Property(x => x.AccommodationStars).IsRequired().HasPrecision(1,1);
            builder.Property(x=>x.DestinationId).IsRequired();
            builder.Property(x=>x.AccommodationTypeId).IsRequired();

            builder.HasMany(x => x.Trips)
                .WithOne(x => x.Accommodation)
                .HasForeignKey(x => x.AccommodationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(x => x.RoomsNumber)
                .WithOne(x => x.Accommodation)
                .HasForeignKey(x => x.AccommodationId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasMany(x => x.Rooms)
                .WithOne(x => x.Accommodation)
                .HasForeignKey(x => x.AccommodationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
