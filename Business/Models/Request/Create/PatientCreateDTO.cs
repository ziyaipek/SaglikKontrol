using System;
using Infrastructure.Data.Postgres.Entities;
namespace Business.Models.Request.Create
{
	public class PatientCreateDTO
	{
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string DateOfBirth { get; set; }
        public string Gender { get; set; } = default!;
        public string ContactInformation { get; set; } = default!;
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string EmergencyContactFirstName { get; set; } = default!;
        public string EmergencyContactLastName { get; set; } = default!;
        public string EmergencyContactPhone { get; set; } = default!;
        public bool IsDeleted { get; set; } = false;
        public bool IsFirstLogin { get; set; } = true;

        //public List<PatientDisease> PatientDiseases { get; set; } = default!;
        //public List<MedicationPatient> MedicationPatients { get; set; } = default!;
    }
}

