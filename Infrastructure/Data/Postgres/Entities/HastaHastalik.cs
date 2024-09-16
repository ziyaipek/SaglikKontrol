using System;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class HastaHastalik : Entity<int>
    {
        public int ID { get; set; }
        public int HastaID { get; set; }
        public Hasta Hasta { get; set; } = default!;
        public int HastalıkID { get; set; }
        public Hastalik Hastalik { get; set; } = default!;
    }
}

