using System;
using System.Collections.Generic; // List<T> için gerekli
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Disease : Entity<int>
    {
        public int DiseaseID { get; set; }
        public string DiseaseName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Symptoms { get; set; } = default!;

        public List<PatientDisease> PatientDiseases { get; set; } = default!;
    }
}
