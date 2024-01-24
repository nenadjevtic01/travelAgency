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
    public class AttractionImageConfiguration : IEntityTypeConfiguration<AttractionImage>
    {
        public void Configure(EntityTypeBuilder<AttractionImage> builder)
        {
            builder.Property(x => x.AttractionImageId).UseIdentityColumn(1, 1);
            builder.Property(x => x.AttractionId).IsRequired();
            builder.Property(x => x.Src).IsRequired();
            builder.Property(x => x.Alt).IsRequired();
        }
    }
}
