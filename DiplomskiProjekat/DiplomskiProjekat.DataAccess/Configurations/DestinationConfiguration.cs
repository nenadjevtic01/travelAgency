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
    public class DestinationConfiguration : IEntityTypeConfiguration<Destination>
    {
        public void Configure(EntityTypeBuilder<Destination> builder)
        {
            builder.Property(x => x.DestinationId).UseIdentityColumn(1, 1);
            builder.Property(x => x.CountryId).IsRequired();
            builder.Property(x => x.DestinationName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.DestinationDescription).IsRequired().HasMaxLength(30);
            builder.Property(x => x.IsActive).IsRequired().HasDefaultValue(true);

            builder
                .HasOne(x => x.Climate)
                .WithOne(x => x.Destination)
                .HasForeignKey<Climate>(x => x.DestinationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(x => x.Trips)
                .WithOne(x => x.Destination)
                .HasForeignKey(x => x.DestinationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(x => x.Images)
                .WithOne(x => x.Destination)
                .HasForeignKey(x => x.DestinationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(x => x.Accommodations)
                .WithOne(x => x.Destination)
                .HasForeignKey(x => x.DestinationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(x => x.Attractions)
                .WithOne(x => x.Destination)
                .HasForeignKey(x => x.DestinationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(x => x.UserFavorites)
                .WithOne(x => x.Destination)
                .HasForeignKey(x => x.DestinationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
