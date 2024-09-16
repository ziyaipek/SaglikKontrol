using System;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class DoktorHasta : Entity<int>
    {
        public int ID { get; set; }
        public int HastaID { get; set; }
        public Hasta Hasta { get; set; } = default!;
        public int DoktorID { get; set; }
        public Doktor Doktor { get; set; } = default!;
    }

}

