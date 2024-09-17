using System;
using Infrastructure.Data.Postgres.Entities;
namespace Business.Models.Request.Create

{
	public class DiseaseCreateDTO
	{
        public string DiseaseName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Symptoms { get; set; } = default!;
        public List<PatientDisease> PatientDiseases { get; set; } = default!;
    }
}

