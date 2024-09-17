using System;
using Infrastructure.Data.Postgres.Entities;
namespace Business.Models.Request.Update
{
	public class DoctorPatientUpdateDTO
	{
        public int PatientID { get; set; }
        public Patient Patient { get; set; } = default!;
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; } = default!;
    }
}

