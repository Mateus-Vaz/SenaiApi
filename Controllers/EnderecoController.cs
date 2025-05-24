using Microsoft.AspNetCore.Mvc;
using SenaiApi.DTos;
using SenaiApi.Servicos.Interface.cs;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;
        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Adicionar(EnderecoDTo endereco)
        {
            _enderecoService.Salvar(endereco);
            return Ok();
        }

        [HttpGet("buscar todos")]
        public IActionResult Buscar()
        {
            var enderecos = _enderecoService.BuscarTodos();
            return Ok(enderecos);
        }
        [HttpPost]
        [Route("Editar")]
        public IActionResult Editar([FromBody] EnderecoDTo endereco)
        {
            if (endereco == null)
            {
                return BadRequest("Escola não pode ser nua");
            }
            _enderecoService.Editar(endereco);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Remover(long id)
        {
            await _enderecoService.Remover(id);
            return Ok();
        }
    }
}