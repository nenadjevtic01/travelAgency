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
    public class TripAccommodationConfiguration : IEntityTypeConfiguration<TripAccommodation>
    {
        public void Configure(EntityTypeBuilder<TripAccommodation> builder)
        {
            builder.HasKey(x => new {x.TripId,x.AccommodationId});
        }
    }
}
