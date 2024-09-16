using System;
namespace Infrastructure.Data.Postgres.Entities
{
    public class DoktorHasta
    {
        public int ID { get; set; }
        public int HastaID { get; set; }
        public int DoktorID { get; set; }
    }

}

