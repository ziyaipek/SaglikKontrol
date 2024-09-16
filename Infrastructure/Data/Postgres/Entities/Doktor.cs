using System;
namespace Infrastructure.Data.Postgres.Entities
{
    public class Doktor
    {
        public int DoktorID { get; set; }
        public string Ad { get; set; } = default!;
        public string Soyad { get; set; } = default!;
        public string İletişimBilgileri { get; set; } = default!;
        public string DkullanıcıAdı { get; set; } = default!;
        public string Dşifre { get; set; } = default!;
        public bool SilmeGostergesi { get; set; }
        public bool IlkGiris { get; set; }

        public List<DoktorHasta> DoktorHastas { get; set; } = default!;
    }

}

