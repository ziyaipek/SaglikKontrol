using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class DoctorConfiguration : BaseConfiguration<Doctor, int>
    {
        public override void Configure(EntityTypeBuilder<Doctor> builder)
        {
            base.Configure(builder);
            var data = new Doctor[]
            {
            new Doctor{ Id = 1,DoctorUsername="Doktor1",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},
            new Doctor{ Id = 2,DoctorUsername="Doktor2",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},
            new Doctor{ Id = 3,DoctorUsername="Doktor3",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},

            };

            builder.HasData(data);
        }
    }
}