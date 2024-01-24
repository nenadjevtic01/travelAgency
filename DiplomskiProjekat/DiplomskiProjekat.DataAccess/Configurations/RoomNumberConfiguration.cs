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
    public class RoomNumberConfiguration : IEntityTypeConfiguration<RoomNumber>
    {
        public void Configure(EntityTypeBuilder<RoomNumber> builder)
        {
            builder.Property(x => x.RoomNumberId).UseIdentityColumn(1, 1);
            builder.Property(x => x.AccommodationId).IsRequired();
            builder.Property(x => x.RoomTypeId).IsRequired();
            builder.Property(x => x.NumberOf).IsRequired().HasMaxLength(2);
        }
    }
}
