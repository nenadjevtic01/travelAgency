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
    public class SafetyConfiguration : IEntityTypeConfiguration<Safety>
    {
        public void Configure(EntityTypeBuilder<Safety> builder)
        {
            builder.Property(x => x.SafetyId).UseIdentityColumn(1, 1);
            builder.Property(x => x.SafetyLevel).IsRequired();
            builder.Property(x => x.Advices).IsRequired().HasMaxLength(255);
            builder.Property(x=>x.CountryId).IsRequired();
            builder.HasIndex(x => x.CountryId).IsUnique();
        }
    }
}
