using System;
using Infrastructure.Data.Postgres.Entities;
namespace Business.Models.Request.Create
{
	public class PatientDiseaseCreateDTO
	{
        
        public int PatientID { get; set; }
        public Patient Patient { get; set; } = default!;
        public int DiseaseID { get; set; }
        public Disease Disease { get; set; } = default!;
    }
}

