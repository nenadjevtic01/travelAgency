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
    public abstract class UserConfiguration<TUser> : EntityConfiguration<TUser>
        where TUser : User
    {
        protected override void ConfigureTableSpecifics(EntityTypeBuilder<TUser> builder)
        {
            builder.Property(x => x.UserId).UseIdentityColumn(1, 1);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(20);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.Discriminator).IsRequired();
            builder.HasIndex(x => x.Email).IsUnique();

            ConfigureRelations(builder);
        }

        protected abstract void ConfigureRelations(EntityTypeBuilder<TUser> builder);
    }
}
