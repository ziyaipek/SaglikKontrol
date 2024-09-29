using System;
using System.Numerics;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class DoctorPatient : Entity<int>
    {
        //public int ID { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; } = default!;
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; } = default!;
    }
}
