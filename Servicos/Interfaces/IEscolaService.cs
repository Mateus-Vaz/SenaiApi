﻿using Microsoft.AspNetCore.Mvc;
using SenaiApi.DTos;
using SenaiApi.Entidades;

namespace SenaiApi.Servicos.Interface.cs
{
    public interface IEscolaService
    {
        List<EscolaDTos> BuscarTodos();
        void Salvar(EscolaDTos escola);

        Task<bool> Remover(long id);
        void Editar(EscolaEdicaoDTo? escola);
    }
}
