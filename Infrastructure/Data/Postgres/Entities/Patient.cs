using System;
using System.Collections.Generic; // List<T> için gerekli
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Patient : Entity<int>
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = default!;
        public string ContactInformation { get; set; } = default!;
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string EmergencyContactFirstName { get; set; } = default!;
        public string EmergencyContactLastName { get; set; } = default!;
        public string EmergencyContactPhone { get; set; } = default!;
        public bool IsDeleted { get; set; }
        public bool IsFirstLogin { get; set; }

        public List<PatientDisease> PatientDiseases { get; set; } = default!;
        public List<MedicationPatient> MedicationPatients { get; set; } = default!;
    }
}
