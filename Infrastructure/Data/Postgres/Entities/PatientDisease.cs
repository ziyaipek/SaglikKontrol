using System;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class PatientDisease : Entity<int>
    {
        //public int ID { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; } = default!;
        public int DiseaseID { get; set; }
        public Disease Disease { get; set; } = default!;
    }
}
