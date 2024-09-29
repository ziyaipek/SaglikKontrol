using System;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class MedicationPatient : Entity<int>
    {
       // public int ID { get; set; }
        public int MedicationID { get; set; }
        public Medication Medication { get; set; } = default!;
        public int PatientID { get; set; }
        public Patient Patient { get; set; } = default!;
    }
}
