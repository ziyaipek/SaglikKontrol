using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data.Postgres.EntityFramework
{
	public class PostgresContext : DbContext
	{
        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options) { }

        private readonly IConfiguration _configuration;

        public PostgresContext(DbContextOptions<PostgresContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorPatientConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new DiseaseConfiguration());
            modelBuilder.ApplyConfiguration(new MedicationPatientConfiguration());
            modelBuilder.ApplyConfiguration(new MedicationConfiguration());
            modelBuilder.ApplyConfiguration(new PatientDiseaseConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (_configuration["EnvironmentAlias"] == "DEV")
            {
                optionsBuilder.LogTo(Console.Write);
            }
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorPatient> DoctorPatients { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientDisease> PatientDiseases { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<MedicationPatient> MedicationPatients { get; set; }
        public DbSet<Medication> Medications { get; set; }
    }
}