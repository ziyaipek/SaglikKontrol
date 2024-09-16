using System;
using Infrastructure.Data.Postgres.EntityFramework;

namespace Infrastructure.Data.Postgres
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        Task<int> CompleteAsync();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PostgresContext _context;
        public UnitOfWork(PostgresContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
        }
        public IUserRepository Users { get; }
        public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();
        public void Dispose() => _context.Dispose();
    }
}

