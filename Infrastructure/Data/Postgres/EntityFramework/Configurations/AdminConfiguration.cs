using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class AdminConfiguration : BaseConfiguration<Admin, int>
    {
        public override void Configure(EntityTypeBuilder<Admin> builder)
        {
            base.Configure(builder);
            var data = new Admin[]
            {
            new Admin{ Id = 1,Username="Emre",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},
            new Admin{ Id = 2,Username="Batuhan",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},
            new Admin{ Id = 3,Username="Ziya",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},
            
            };

            builder.HasData(data);
        }
    }
}