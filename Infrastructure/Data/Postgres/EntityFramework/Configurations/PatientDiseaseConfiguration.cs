using Core.Utilities;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class PatientDiseaseConfiguration : BaseConfiguration<PatientDisease, int>
    {
        public override void Configure(EntityTypeBuilder<PatientDisease> builder)
        {
            base.Configure(builder);
            var data = new PatientDisease[]
            {
            //new PatientDisease{ Id = 1,CreatedAt = DateTime.UtcNow.ToTimeZone(),IsDeleted=false},
            //new PatientDisease{ Id = 2,CreatedAt = DateTime.UtcNow.ToTimeZone(),IsDeleted=false},
            //new PatientDisease{ Id = 3,CreatedAt = DateTime.UtcNow.ToTimeZone(),IsDeleted=false},

            };

            builder.HasData(data);
        }
    }
}