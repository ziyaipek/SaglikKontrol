using System;
using System.Collections.Generic;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Postgres.EntityFramework
{
	public class PostgresContext : DBContext
	{
        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options) { }

        public DbSet<Yonetici> Yoneticiler { get; set; }
        public DbSet<Doktor> Doktorlar { get; set; }
        public DbSet<DoktorHasta> DoktorHastalar { get; set; }
        public DbSet<Hasta> Hastalar { get; set; }
        public DbSet<HastaHastalik> HastaHastaliklar { get; set; }
        public DbSet<Hastalik> Hastaliklar { get; set; }
        public DbSet<IlacHasta> IlacHastalar { get; set; }
        public DbSet<Ilaclar> Ilaclar { get; set; }
    }

    
}

