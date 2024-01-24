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
    public class AttractionConfiguration : IEntityTypeConfiguration<Attraction>
    {
        public void Configure(EntityTypeBuilder<Attraction> builder)
        {
            builder.Property(x => x.AttractionId).UseIdentityColumn(1, 1);
            builder.Property(x=>x.DestinationId).IsRequired();
            builder.Property(x=>x.AttractionName).IsRequired().HasMaxLength(20);
            builder.Property(x=>x.AttractionDescription).IsRequired().HasMaxLength(30);
            builder.Property(x => x.AttractionCategoryId).IsRequired();

            builder
                .HasMany(x=>x.Trips)
                .WithOne(x=>x.Attraction)
                .HasForeignKey(x=>x.AttractionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(x => x.AttractionImages)
                .WithOne(x => x.Attraction)
                .HasForeignKey(x => x.AttractionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
