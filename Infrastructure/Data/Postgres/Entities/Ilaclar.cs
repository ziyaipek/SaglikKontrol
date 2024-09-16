using System;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Ilaclar : Entity<int>
    {
        public int İlaçID { get; set; }
        public string İlaçAdı { get; set; } = default!;
        public string EtkenMadde { get; set; } = default!;
        public string KullanımTalimatları { get; set; } = default!;

        public List<IlacHasta> IlacHastas { get; set; } = default!;


    }

}

