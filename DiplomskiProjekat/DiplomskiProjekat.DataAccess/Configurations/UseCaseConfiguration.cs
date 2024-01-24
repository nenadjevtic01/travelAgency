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
    public class UseCaseConfiguration : IEntityTypeConfiguration<UseCase>
    {
        public void Configure(EntityTypeBuilder<UseCase> builder)
        {
            builder.Property(x => x.UseCaseId).UseIdentityColumn(1, 1);
            builder.Property(x => x.UseCaseName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.UseCaseDescription).IsRequired().HasMaxLength(50);

            builder
                .HasMany(x => x.Users)
                .WithOne(x => x.UseCase)
                .HasForeignKey(x => x.UseCaseId)
                .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}
