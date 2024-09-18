using System.Data;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;


namespace Infrastructure.Data.Postgres.Repositories
{
    public class AdminRepository : Repository<Admin, int>, IAdminRepository
    {
        public AdminRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
    }
}
