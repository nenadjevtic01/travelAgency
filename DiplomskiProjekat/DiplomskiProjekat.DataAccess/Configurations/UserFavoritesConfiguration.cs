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
    public class UserFavoritesConfiguration : IEntityTypeConfiguration<UserFavorites>
    {
        public void Configure(EntityTypeBuilder<UserFavorites> builder)
        {
            builder.Property(x => x.UserFavoritesId).UseIdentityColumn(1, 1);
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.DestinationId).IsRequired();
        }
    }
}
