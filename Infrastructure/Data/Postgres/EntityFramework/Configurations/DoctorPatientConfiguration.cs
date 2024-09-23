using Core.Utilities;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class DoctorPatientConfiguration : BaseConfiguration<DoctorPatient, int>
    {
        public override void Configure(EntityTypeBuilder<DoctorPatient> builder)
        {
            base.Configure(builder);
            var data = new DoctorPatient[]
            {
            new DoctorPatient{ Id = 1,CreatedAt = DateTime.UtcNow.ToTimeZone(),IsDeleted=false},
            new DoctorPatient{ Id = 2,CreatedAt = DateTime.UtcNow.ToTimeZone(),IsDeleted=false},
            new DoctorPatient{ Id = 3,CreatedAt = DateTime.UtcNow.ToTimeZone(),IsDeleted=false},

            };

            builder.HasData(data);
        }
    }
}