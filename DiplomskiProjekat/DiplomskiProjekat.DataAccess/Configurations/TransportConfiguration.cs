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
    public class TransportConfiguration : IEntityTypeConfiguration<Transport>
    {
        public void Configure(EntityTypeBuilder<Transport> builder)
        {
            builder.Property(x => x.TransportId).UseIdentityColumn(1, 1);
            builder.Property(x => x.TransportName).IsRequired().HasMaxLength(20);

            builder
                .HasMany(x => x.TripList)
                .WithOne(x => x.Transport)
                .HasForeignKey(x => x.TransportId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
