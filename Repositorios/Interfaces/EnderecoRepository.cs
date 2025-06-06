﻿using Microsoft.EntityFrameworkCore;
using SenaiApi.Contexto;
using SenaiApi.Entidades;

namespace SenaiApi.Repositorios.Interfaces
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        private readonly SenaiContext _context;
        public EnderecoRepository(SenaiContext context) : base(context) 
        {
            _context = context;
        }
        public void Salvar(Endereco endereco)
        {
            if (endereco.Id == 0)
                _context.Endereco.Add(endereco);
            else
                _context.Endereco.Update(endereco);

            _context.SaveChanges();

        }
        public List<Endereco> PegarTodos()
        {
            return base.PegarTodos();
        }
        public async Task<bool> Remover(long id)
        {
            try

            {
                await _context.Endereco.Where(u => u.Id == id).ExecuteDeleteAsync();

                return true;

            }
            catch
            {
                return false;
            }

        }
        public Endereco ObterPorId(long id)
        {
            return _context.Endereco.FirstOrDefault(e => e.Id == id);
        }
        public List<Endereco> ObterTodos()
        {
            return base.ObterTodos().ToList();
        }
    }
}