using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenThumb.Database
{
    public class Repoository<T> where T : class
    {
        private readonly AppDbcontext _context;

        private readonly DbSet<T> _dbSet;

        public Repoository(AppDbcontext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public async Task<T> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);

        public async Task RemoveAsync(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();

    }
}
