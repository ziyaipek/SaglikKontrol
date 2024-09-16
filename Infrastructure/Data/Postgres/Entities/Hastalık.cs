using System;
namespace Infrastructure.Data.Postgres.Entities
{
    public class Hastalik
    {
        public int HastalıkID { get; set; }
        public string HastalıkAdı { get; set; } = default!;
        public string Tanım { get; set; } = default!;
        public string Semptomlar { get; set; } = default!;

        public List<HastaHastalik> HastaHastaliks { get; set; } = default!;

    }
}

