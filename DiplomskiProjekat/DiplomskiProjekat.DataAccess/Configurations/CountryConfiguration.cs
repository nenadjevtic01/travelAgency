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
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(x => x.CountryId).UseIdentityColumn(1, 1);
            builder.Property(x => x.CountryName).IsRequired().HasMaxLength(20);
            builder.Property(x => x.CapitalCity).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Population).IsRequired().HasMaxLength(20);
            builder.Property(x => x.TotalArea).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Currency).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Language).IsRequired().HasMaxLength(20);

            builder
                .HasOne(x=>x.Safety)
                .WithOne(x=>x.Country)
                .HasForeignKey<Safety>(x=>x.CountryId)
                .OnDelete(DeleteBehavior.Restrict); 

            builder
                .HasMany(x => x.Destination)
                .WithOne(x => x.Country)
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.VisaInfo)
                .WithOne(x => x.Country)
                .HasForeignKey<Visa>(x => x.CountryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
