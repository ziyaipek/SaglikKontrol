using System;
using Infrastructure.Data.Postgres.Entities;
namespace Business.Models.Request.Update
{
	public class MedicationPatientUpdateDTO
	{
        public int MedicationID { get; set; }
        public Medication Medication { get; set; } = default!;
        public int PatientID { get; set; }
        public Patient Patient { get; set; } = default!;
    }
}

