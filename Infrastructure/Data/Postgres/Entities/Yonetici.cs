using System;
namespace Infrastructure.Data.Postgres.Entities
{
	public class Yonetici
	{
        public int YöneticiID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Iletisimbilgileri { get; set; }
        public string Ykullaniciadi { get; set; }
        public string Ysifre { get; set; }
    }
}

