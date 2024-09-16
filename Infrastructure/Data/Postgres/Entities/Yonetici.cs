using System;
namespace Infrastructure.Data.Postgres.Entities
{
	public class Yonetici
	{
        public int YöneticiID { get; set; }
        public string Ad { get; set; } = default!;
        public string Soyad { get; set; } = default!;
        public string İletişimBilgileri { get; set; } = default!;
        public string YkullanıcıAdı { get; set; } = default!;
        public string Yşifre { get; set; } = default!;
    }
}

