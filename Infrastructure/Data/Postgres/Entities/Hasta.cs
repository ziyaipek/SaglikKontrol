using System;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Hasta : Entity<int>
    {
        public int HastaID { get; set; }
        public string Ad { get; set; } = default!;
        public string Soyad { get; set; } = default!;
        public DateTime DoğumTarihi { get; set; }
        public string Cinsiyet { get; set; } = default!;
        public string İletişimBilgileri { get; set; } = default!;
        public string HkullanıcıAdı { get; set; } = default!;
        public string Hşifre { get; set; } = default!;
        public string AcilDurumAd { get; set; } = default!;
        public string AcilDurumSoyad { get; set; } = default!;
        public string AcilDurumTel { get; set; } = default!;
        public bool SilmeGostergesi { get; set; }
        public bool IlkGiris { get; set; }

        public List<DoktorHasta> DoktorHastas { get; set; } = default!;
        public List<HastaHastalik> HastaHastaliks { get; set; } = default!;
        public List<IlacHasta> IlacHastas { get; set; } = default!;



    }
}

