using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using SenaiApi.Contexto;
using SenaiApi.DTos;
using SenaiApi.Entidades;
using SenaiApi.Repositorios.Interfaces;

namespace SenaiApi.Repositorios
{
    public class EscolaRepository : IEscolaRepository
    {
        private readonly SenaiContext _context;
        public EscolaRepository(SenaiContext context)
        {
            _context = context;
        }

        public void Salvar(Escola escola)
        {
            if (escola.Id == 0)
                _context.Escola.Add(escola);
            else
                _context.Escola.Update(escola);

            _context.SaveChanges();

        }
        public List<Escola> PegarTodos()
        {
            return _context.Escola.ToList();
        }
        public async Task<bool> Remover(long id)
        {
            try

            {
                await _context.Escola.Where(u => u.Id == id).ExecuteDeleteAsync();

                return true;

            }
            catch
            {
                return false;
            }

        }
        public Escola ObterPorId(long id)
        {
            return _context.Escola.FirstOrDefault(e => e.Id == id);
        }
        public List<Escola> ObterTodos()
        {
            return _context.Escola.ToList();
        }
    }
}