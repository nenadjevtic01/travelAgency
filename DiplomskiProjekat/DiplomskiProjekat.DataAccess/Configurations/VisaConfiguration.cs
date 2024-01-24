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
    public class VisaConfiguration : IEntityTypeConfiguration<Visa>
    {
        public void Configure(EntityTypeBuilder<Visa> builder)
        {
            builder.Property(x => x.VisaId).UseIdentityColumn(1, 1);
            builder.Property(x => x.VisaType).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Duration).IsRequired();
            builder.Property(x => x.Requirements).IsRequired();
        }
    }
}
