using System;
using System.Collections.Generic; // List<T> için gerekli
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Medication : Entity<int>
    {
        public string MedicationName { get; set; } = default!;
        public string ActiveIngredient { get; set; } = default!;
        public string UsageInstructions { get; set; } = default!;

        public List<MedicationPatient> MedicationPatients { get; set; } = default!;
    }
}
