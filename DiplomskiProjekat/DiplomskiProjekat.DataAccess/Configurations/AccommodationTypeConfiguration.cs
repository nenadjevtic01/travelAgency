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
    public class AccommodationTypeConfiguration : IEntityTypeConfiguration<AccommodationType>
    {
        public void Configure(EntityTypeBuilder<AccommodationType> builder)
        {
            builder.Property(x=>x.AccommodationTypeId).UseIdentityColumn(1,1);
            builder.Property(x => x.AccommodationTypeName).IsRequired().HasMaxLength(20);

            builder
                .HasMany(x => x.Accommodations)
                .WithOne(x => x.AccommodationType)
                .HasForeignKey(x => x.AccommodationTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
