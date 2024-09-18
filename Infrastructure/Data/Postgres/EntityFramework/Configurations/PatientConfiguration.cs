using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class PatientConfiguration : BaseConfiguration<Patient, int>
    {
        public override void Configure(EntityTypeBuilder<Patient> builder)
        {
            base.Configure(builder);
            var data = new Patient[]
            {
            new Patient{ Id = 1,Username="Hastalık1",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},
            new Patient{ Id = 2,Username="Hastalık2",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},
            new Patient{ Id = 3,Username="Hastalık3",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},

            };

            builder.HasData(data);
        }
    }
}