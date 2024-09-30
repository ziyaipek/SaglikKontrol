using System;
using Infrastructure.Data.Postgres.Entities;
namespace Business.Models.Request.Update
{
	public class DoctorUpdateDTO
	{
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string ContactInformation { get; set; } = default!;
        public string DoctorUsername { get; set; } = default!;
        public string DoctorPassword { get; set; } = default!;
        public bool IsDeleted { get; set; } = false;
        public bool IsFirstLogin { get; set; } = true;

        //public List<DoctorPatient> DoctorPatients { get; set; } = default!;
    }
}

