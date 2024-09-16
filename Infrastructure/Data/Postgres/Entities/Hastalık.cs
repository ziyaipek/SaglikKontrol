using System;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Hastalik : Entity<int>
    {
        public int HastalıkID { get; set; }
        public string HastalıkAdı { get; set; } = default!;
        public string Tanım { get; set; } = default!;
        public string Semptomlar { get; set; } = default!;

        public List<HastaHastalik> HastaHastaliks { get; set; } = default!;

    }
}

