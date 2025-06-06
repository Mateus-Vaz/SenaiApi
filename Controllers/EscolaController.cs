﻿using Microsoft.AspNetCore.Mvc;
using SenaiApi.DTos;
using SenaiApi.Entidades;
using SenaiApi.Servicos;
using SenaiApi.Servicos.Interface.cs;

namespace SenaiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EscolaController : ControllerBase
    {
        private readonly IEscolaService _escolaService;
        public EscolaController(IEscolaService escolaService)
        {
            _escolaService = escolaService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Adicionar(EscolaDTos escola)
        {
            _escolaService.Salvar(escola);
            return Ok();
        }
        [HttpGet("buscar todos")]
        public IActionResult Buscar()
        {
            var escolas = _escolaService.BuscarTodos();
            return Ok(escolas);
        }
        [HttpPost]
        [Route("Editar")]
        public IActionResult Editar([FromBody] EscolaEdicaoDTo escola)
        {
            if (escola == null)
            {
                return BadRequest("Escola não pode ser nua");
            }
             _escolaService.Editar(escola);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Remover(long id)
        {
           await _escolaService.Remover(id);
            return Ok();
        }
    }
}