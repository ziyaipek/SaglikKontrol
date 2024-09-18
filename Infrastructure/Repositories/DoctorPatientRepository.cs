using System.Data;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;


namespace Infrastructure.Data.Postgres.Repositories
{
    public class DoctorPatientRepository : Repository<DoctorPatient, int>, IDoctorPatientRepository
    {
        public DoctorPatientRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
    }
}


