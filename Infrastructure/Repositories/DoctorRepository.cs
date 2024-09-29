using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using System.Linq;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class DoctorRepository : Repository<Doctor, int>, IDoctorRepository
    {
        private readonly PostgresContext _context;

        public DoctorRepository(PostgresContext postgresContext) : base(postgresContext)
        {
            _context = postgresContext;
        }

        // Kullanıcı adına göre Doctor döndür
        public Doctor GetByUsername(string username)
        {
            return _context.Doctors.SingleOrDefault(doctor => doctor.DoctorUsername == username);
        }

        // Doktor'un veritabanında mevcut olup olmadığını kontrol et (gerekirse)
        public bool Exists(string username)
        {
            return _context.Doctors.Any(doctor => doctor.DoctorUsername == username);
        }
    }
}
