using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Salvar([FromBody] EscolaDTos escola)
        {
            if (escola == null)
            {
                return BadRequest("Escola não pode ser nua");
            }
            _escolaService.Salvar(escola);
            return Ok();
        }
        [HttpGet("buscar-todos")]
        public IActionResult Buscar()
        {
            var escolas = _escolaService.BuscarTodos();
            return Ok(escolas);
        }
       
        [HttpDelete]
        public async Task<IActionResult> Remover(long id)
        {
           await _escolaService.Remover(id);
            return Ok();
        }
        [HttpGet("PegarPorId")]
        public IActionResult PegarPorId(long id)
        {
            var escolas = _escolaService.ObterPorId(id);
            return Ok(escolas);
        }
    }
}