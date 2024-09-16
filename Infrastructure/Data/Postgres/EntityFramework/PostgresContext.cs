using System;
using System.Collections.Generic;

namespace Infrastructure.Data.Postgres.EntityFramework
{
	public class PostgresContext : DBContext
	{
        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options) { }
        public DbSet<Yonetici> Users { get; set; }
    }
}

