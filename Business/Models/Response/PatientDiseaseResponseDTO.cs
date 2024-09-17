using System;
using Infrastructure.Data.Postgres.Entities;
namespace Business.Models.Response
{
	public class PatientDiseaseResponseDTO
	{
        public int PatientID { get; set; }
        public Patient Patient { get; set; } = default!;
        public int DiseaseID { get; set; }
        public Disease Disease { get; set; } = default!;
    }
}

