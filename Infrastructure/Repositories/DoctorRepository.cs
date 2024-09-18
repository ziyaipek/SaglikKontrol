using System.Data;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;


namespace Infrastructure.Data.Postgres.Repositories
{
    public class DoctorRepository : Repository<Doctor, int>, IDoctorRepository
    {
        public DoctorRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
    }
}


