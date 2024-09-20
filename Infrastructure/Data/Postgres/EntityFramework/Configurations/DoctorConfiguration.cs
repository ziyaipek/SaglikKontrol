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
            new Doctor{ Id = 1,FirstName="A",LastName="A",ContactInformation="0555",DoctorUsername="Doktor1"
            ,DoctorPassword="123",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},
             new Doctor{ Id = 2,FirstName="B",LastName="B",ContactInformation="0555",DoctorUsername="Doktor2"
            ,DoctorPassword="123",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},
             new Doctor{ Id = 3,FirstName="C",LastName="C",ContactInformation="0555",DoctorUsername="Doktor3"
            ,DoctorPassword="123",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},

            };

            builder.HasData(data);
        }
    }
}