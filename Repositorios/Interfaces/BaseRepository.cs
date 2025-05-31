
using Microsoft.EntityFrameworkCore;
using SenaiApi.Contexto;

namespace SenaiApi.Repositorios.Interfaces
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly SenaiContext _context;
        protected readonly DbSet<T> _DbSet;
        public BaseRepository(SenaiContext context)
        {
            _context = context;
            _DbSet = context.Set<T>();
        }

        public IQueryable<T> ObterTodos()
        {
            return _DbSet;
        }
        public List<T> PegarTodos()
        {
            return _DbSet.ToList();
        }

    }
}
