using System;
using System.Collections.Generic;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Postgres.EntityFramework
{
	public class PostgresContext : DbContext
	{
        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options) { }

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

