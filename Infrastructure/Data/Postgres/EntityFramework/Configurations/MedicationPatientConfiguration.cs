using Core.Utilities;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class MedicationPatientConfiguration : BaseConfiguration<MedicationPatient, int>
    {
        public override void Configure(EntityTypeBuilder<MedicationPatient> builder)
        {
            base.Configure(builder);
            var data = new MedicationPatient[]
            {
            new MedicationPatient{ Id = 1,CreatedAt = DateTime.UtcNow.ToTimeZone(),IsDeleted=false},
            new MedicationPatient{ Id = 2,CreatedAt = DateTime.UtcNow.ToTimeZone(),IsDeleted=false},
            new MedicationPatient{ Id = 3,CreatedAt = DateTime.UtcNow.ToTimeZone(),IsDeleted=false},

            };

            builder.HasData(data);
        }
    }
}