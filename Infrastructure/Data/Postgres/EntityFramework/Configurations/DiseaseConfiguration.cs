using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class DiseaseConfiguration : BaseConfiguration<Disease, int>
    {
        public override void Configure(EntityTypeBuilder<Disease> builder)
        {
            base.Configure(builder);
            var data = new Disease[]
            {
            new Disease{ Id = 1,DiseaseName="Hasta1",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},
            new Disease{ Id = 2,DiseaseName="Hasta2",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},
            new Disease{ Id = 3,DiseaseName="Hasta3",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},

            };

            builder.HasData(data);
        }
    }
}