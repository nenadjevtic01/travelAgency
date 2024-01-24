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
    public class AttractionCategoryConfiguration : IEntityTypeConfiguration<AttractionCategory>
    {
        public void Configure(EntityTypeBuilder<AttractionCategory> builder)
        {
            builder.Property(x => x.AttractionCategoryId).UseIdentityColumn(1, 1);
            builder.Property(x => x.AttractionCategoryName).IsRequired().HasMaxLength(15);

            builder
                .HasMany(x => x.Attractions)
                .WithOne(x => x.AttractionCategory)
                .HasForeignKey(x => x.AttractionCategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
