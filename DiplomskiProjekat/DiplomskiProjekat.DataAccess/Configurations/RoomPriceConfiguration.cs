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
    public class RoomPriceConfiguration : IEntityTypeConfiguration<RoomPrice>
    {
        public void Configure(EntityTypeBuilder<RoomPrice> builder)
        {
            builder.Property(x => x.RoomPriceId).UseIdentityColumn(1, 1);
            builder.Property(x => x.RoomId).IsRequired();
            builder.Property(x => x.Price).IsRequired().HasPrecision(6, 2);
            builder.Property(x => x.ValidFrom).IsRequired().HasDefaultValueSql("GETDATE()");
        }
    }
}
