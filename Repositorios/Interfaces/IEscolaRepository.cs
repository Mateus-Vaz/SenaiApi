﻿using SenaiApi.DTos;
using SenaiApi.Entidades;

namespace SenaiApi.Repositorios.Interfaces
{
    public interface IEscolaRepository
    {
        public List<Escola> PegarTodos();

        void Salvar(Escola escola);

        Task<bool> Remover(long id);

        Escola ObterPorId(long id);
    }
}
