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

            };

            builder.HasData(data);
        }
    }
}