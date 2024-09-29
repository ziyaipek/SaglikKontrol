using System;
using Infrastructure.Data.Postgres.Entities;
namespace Business.Models.Response
{
	public class MedicationResponseDTO
	{
        public int Id { get; set; } = default!;
        public string MedicationName { get; set; } = default!;
        public string ActiveIngredient { get; set; } = default!;
        public string UsageInstructions { get; set; } = default!;
        public List<MedicationPatient> MedicationPatients { get; set; } = default!;
    }
}

