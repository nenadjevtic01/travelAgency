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
    public class RoomTypePriceConfiguration : IEntityTypeConfiguration<RoomTypePrice>
    {
        public void Configure(EntityTypeBuilder<RoomTypePrice> builder)
        {
            builder.Property(x => x.RoomTypePriceId).UseIdentityColumn(1, 1);
            builder.Property(x => x.AccommodationId).IsRequired();
            builder.Property(x => x.RoomTypeId).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.ValidFrom).IsRequired().HasDefaultValueSql("GETDATE()");

            builder
                .HasMany(x => x.RoomReservations)
                .WithOne(x => x.RoomTypePrice)
                .HasForeignKey(x => x.RoomTypePriceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
