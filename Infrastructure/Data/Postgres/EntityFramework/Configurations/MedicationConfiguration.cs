using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class MedicationConfiguration : BaseConfiguration<Medication, int>
    {
        public override void Configure(EntityTypeBuilder<Medication> builder)
        {
            base.Configure(builder);
            var data = new Medication[]
            {
            new Medication{ Id = 1,MedicationName="İlaç1",ActiveIngredient="3",UsageInstructions="2",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},
            new Medication{ Id = 2,MedicationName="İlaç2",ActiveIngredient="3",UsageInstructions="2",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},
            new Medication{ Id = 3,MedicationName="İlaç3",ActiveIngredient="3",UsageInstructions="2",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},

            };

            builder.HasData(data);
        }
    }
}