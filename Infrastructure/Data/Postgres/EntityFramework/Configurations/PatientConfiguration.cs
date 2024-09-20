﻿using Infrastructure.Data.Postgres.Entities;
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
            new Patient{ Id = 1,FirstName="XX",LastName="XX",Gender="M",DateOfBirth=new DateTime(2023, 9, 20),Username="Hasta1",ContactInformation="0555",EmergencyContactFirstName="X"
            ,EmergencyContactLastName="X",EmergencyContactPhone="0256",Password="123",CreatedAt = DateTime.UtcNow.ToLocalTime(),IsDeleted=false},
            };

            builder.HasData(data);
        }
    }
}