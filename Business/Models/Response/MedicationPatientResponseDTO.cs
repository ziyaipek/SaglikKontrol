using System;
using Infrastructure.Data.Postgres.Entities;
namespace Business.Models.Response
{
	public class MedicationPatientResponseDTO
	{
        public int Id { get; set; } = default!;
        public int MedicationID { get; set; }
        public Medication Medication { get; set; } = default!;
        public int PatientID { get; set; }
        public Patient Patient { get; set; } = default!;
    }
}

