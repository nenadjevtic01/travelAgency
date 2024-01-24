using DiplomskiProjekat.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.DataAccess.Configurations
{
    public class AgencyEmployeeConfiguration : UserConfiguration<AgencyEmployee>
    {
        protected override void ConfigureRelations(EntityTypeBuilder<AgencyEmployee> builder)
        {
            
        }
    }
}
