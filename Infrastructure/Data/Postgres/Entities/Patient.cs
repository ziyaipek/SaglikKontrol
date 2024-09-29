using System;
using System.Collections.Generic; // List<T> için gerekli
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Patient : Entity<int>
    {
        //public int PatientID { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string ContactInformation { get; set; } 
        public string Username { get; set; }
        public string Password { get; set; } 
        public string EmergencyContactFirstName { get; set; } 
        public string EmergencyContactLastName { get; set; } 
        public string EmergencyContactPhone { get; set; } 
        public new bool IsDeleted { get; set; }
        public bool IsFirstLogin { get; set; }

        public List<PatientDisease> PatientDiseases { get; set; } 
        public List<MedicationPatient> MedicationPatients { get; set; }
    }
}
