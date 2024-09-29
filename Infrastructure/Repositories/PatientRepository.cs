using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using System.Linq;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class PatientRepository : Repository<Patient, int>, IPatientRepository
    {
        private readonly PostgresContext _context;

        public PatientRepository(PostgresContext postgresContext) : base(postgresContext)
        {
            _context = postgresContext;
        }

        // Kullanıcı adına göre Patient döndür
        public Patient GetByUsername(string username)
        {
            return _context.Patients.SingleOrDefault(patient => patient.Username == username);
        }

        // Hasta'nın veritabanında mevcut olup olmadığını kontrol et (gerekirse)
        public bool Exists(string username)
        {
            return _context.Patients.Any(patient => patient.Username == username);
        }
    }
}
