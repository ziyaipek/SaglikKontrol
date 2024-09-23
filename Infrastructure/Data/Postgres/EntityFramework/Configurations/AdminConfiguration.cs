using Core.Utilities;
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
            new Admin{ Id = 1,FirstName="Emre",LastName="Oz",ContactInformation="0555",Username="Emre",Password="123",CreatedAt = DateTime.UtcNow.ToTimeZone(),IsDeleted=false},
            new Admin{ Id = 2,FirstName="Batuhan",LastName="Ya",ContactInformation="0555",Username="Batuhan",Password="123",CreatedAt = DateTime.UtcNow.ToTimeZone(),IsDeleted=false},
            new Admin{ Id = 3,FirstName="Ziya",LastName="XX",ContactInformation="0555",Username="Ziya",Password="123",CreatedAt = DateTime.UtcNow.ToTimeZone(),IsDeleted=false},

            };

            builder.HasData(data);
        }
    }
}