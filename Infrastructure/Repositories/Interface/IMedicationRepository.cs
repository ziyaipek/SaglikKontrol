using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using System.Data;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface IMedicationRepository : IRepository<Medication, int>
    {
    }
}