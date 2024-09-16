using System;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class IlacHasta : Entity<int>
    {
        public int ID { get; set; }
        public int İlaçID { get; set; }
        public Ilaclar Ilaclar { get; set; } = default!;
        public int HastaID { get; set; }
        public Hasta Hasta { get; set; } = default!;
    }
}

