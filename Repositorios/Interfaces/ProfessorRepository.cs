using Microsoft.EntityFrameworkCore;
using SenaiApi.Contexto;
using SenaiApi.Entidades;

namespace SenaiApi.Repositorios.Interfaces
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        private readonly SenaiContext _context;
        public ProfessorRepository(SenaiContext context) : base(context)
        {
            _context = context;
        }
        public void Salvar(Professor professor)
        {
            if (professor.Id == 0)
                _context.Professor.Add(professor);
            else
                _context.Professor.Update(professor);

            _context.SaveChanges();

        }
        public List<Professor> PegarTodos()
        {
            return base.PegarTodos();
        }
        public async Task<bool> Remover(long id)
        {
            try

            {
                await _context.Professor.Where(u => u.Id == id).ExecuteDeleteAsync();

                return true;

            }
            catch
            {
                return false;
            }

        }
        public Professor ObterPorId(long id)
        {
            return _context.Professor.FirstOrDefault(e => e.Id == id);
        }
        public List<Professor> ObterTodos()
        {
            return base.ObterTodos().ToList();
        }
    }
}
    

