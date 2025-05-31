using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entidades;
using SenaiApi.Repositorios.Interfaces;

namespace SenaiApi.Servicos.Interfaces
{
    public class ProfessorService : IProfessorService
    {
        private readonly IMapper _mapper;
        private readonly IProfessorRepository _professorRepository;

        public ProfessorService(IMapper mapper, IProfessorRepository professorRepository)
        {
            _mapper = mapper;
            _professorRepository = professorRepository;
        }

        public void Salvar(ProfessorDTo professorDTo)
        {
            var professor = _mapper.Map<Professor>(professorDTo);
            _professorRepository.Salvar(professor);
        }
        public List<ProfessorDTo> BuscarTodos()
        {
            var professores = _professorRepository.PegarTodos();
            return _mapper.Map<List<ProfessorDTo>>(professores);

        }
        public void Editar(ProfessorDTo model)
        {
            var professor = _professorRepository.ObterPorId(model.Id);
            _mapper.Map(model, professor);

            _professorRepository.Salvar(professor);
        }
        public async Task<bool> Remover(long id)
        {
            return await _professorRepository.Remover(id);
        }

    }
}
    

