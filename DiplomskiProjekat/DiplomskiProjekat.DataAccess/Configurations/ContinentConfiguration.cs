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
    public class ContinentConfiguration : IEntityTypeConfiguration<Continent>
    {
        public void Configure(EntityTypeBuilder<Continent> builder)
        {
            builder.Property(x => x.ContinentId).UseIdentityColumn(1, 1);
            builder.Property(x => x.ContinentName).IsRequired();

            builder
                .HasMany(x=>x.Countries)
                .WithOne(x=>x.Continent)
                .HasForeignKey(x=>x.ContinentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
