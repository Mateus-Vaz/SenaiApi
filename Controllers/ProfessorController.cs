using Microsoft.AspNetCore.Mvc;
using SenaiApi.DTos;
using SenaiApi.Servicos.Interface.cs;
using SenaiApi.Servicos.Interfaces;

namespace SenaiApi.Controllers
{
    [ApiController]
        [Route("[controller]")]
        public class ProfessorController : ControllerBase
        {
            private readonly IProfessorService _professorService;
            public ProfessorController(IProfessorService professorService)
            {
                _professorService = professorService;
            }

            [HttpGet]
            public IActionResult Index()
            {
                return Ok();
            }

            [HttpPost]
            public IActionResult Adicionar(ProfessorDTo professor)
            {
                _professorService.Salvar(professor);
                return Ok();
            }

            [HttpGet("buscar todos")]
            public IActionResult Buscar()
            {
                var professores = _professorService.BuscarTodos();
                return Ok(professores);
            }
            [HttpPost]
            [Route("Editar")]
            public IActionResult Editar([FromBody] ProfessorDTo professor)
            {
                if (professor == null)
                {
                    return BadRequest("Escola não pode ser nua");
                }
                _professorService.Editar(professor);
                return Ok();
            }

            [HttpDelete]
            public async Task<IActionResult> Remover(long id)
            {
                await _professorService.Remover(id);
                return Ok();
            }
        }
    }


