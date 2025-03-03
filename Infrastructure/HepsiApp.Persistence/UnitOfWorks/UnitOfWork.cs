using HepsiApp.Application.Interfaces.Repositories;
using HepsiApp.Application.Interfaces.UnitOfWorks;
using HepsiApp.Persistence.Context;
using HepsiApp.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApp.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext _context)
        {
            this._context = _context;
        }
        public async ValueTask DisposeAsync() => await _context.DisposeAsync();
        public int Save() => _context.SaveChanges();
        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();
        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(_context);
        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(_context);
    }
}
