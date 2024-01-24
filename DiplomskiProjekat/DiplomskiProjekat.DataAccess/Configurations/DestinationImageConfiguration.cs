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
    public class DestinationImageConfiguration : IEntityTypeConfiguration<DestinationImage>
    {
        public void Configure(EntityTypeBuilder<DestinationImage> builder)
        {
            builder.Property(x => x.DestinationImageId).UseIdentityColumn(1, 1);
            builder.Property(x => x.DestinationId).IsRequired();
            builder.Property(x => x.Src).IsRequired();
            builder.Property(x=>x.Alt).IsRequired().HasMaxLength(20);
        }
    }
}
