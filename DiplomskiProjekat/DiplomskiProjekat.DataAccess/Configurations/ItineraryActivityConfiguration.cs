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
    public class ItineraryActivityConfiguration : IEntityTypeConfiguration<ItineraryActivity>
    {
        public void Configure(EntityTypeBuilder<ItineraryActivity> builder)
        {
            builder.Property(x => x.ItineraryActivityId).UseIdentityColumn(1, 1);
            builder.Property(x => x.ItineraryId).IsRequired();
            builder.Property(x => x.Day).IsRequired().HasMaxLength(1);
            builder.Property(x => x.Activity).IsRequired().HasMaxLength(100);
        }
    }
}
