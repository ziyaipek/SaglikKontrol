using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using System.Linq;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class AdminRepository : Repository<Admin, int>, IAdminRepository
    {
        private readonly PostgresContext _context;

        public AdminRepository(PostgresContext postgresContext) : base(postgresContext)
        {
            _context = postgresContext;
        }

        // Kullanıcı adına göre Admin döndür
        public Admin GetByUsername(string username)
        {
            return _context.Admins.SingleOrDefault(admin => admin.Username == username);
        }

        // Admin'in veritabanında mevcut olup olmadığını kontrol et (gerekirse)
        public bool Exists(string username)
        {
            return _context.Admins.Any(admin => admin.Username == username);
        }
    }
}
