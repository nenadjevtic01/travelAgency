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
    public class AgencyConfiguration : IEntityTypeConfiguration<Agency>
    {
        public void Configure(EntityTypeBuilder<Agency> builder)
        {
            builder.Property(x => x.AgencyId).UseIdentityColumn(1,1);
            builder.Property(x => x.AgencyName).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(15);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(15);

            builder
                .HasMany(x => x.Employees)
                .WithOne(x => x.Agency)
                .HasForeignKey(x => x.AgencyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(x => x.Trips)
                .WithOne(x => x.Agency)
                .HasForeignKey(x => x.AgencyId)
                .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}
