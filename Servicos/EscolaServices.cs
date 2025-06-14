using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entidades;
using SenaiApi.Repositorios;
using SenaiApi.Repositorios.Interfaces;
using SenaiApi.Servicos.Interface.cs;

namespace SenaiApi.Servicos
{
    public class EscolaServices : IEscolaService
    {
        private readonly IMapper _mapper;
        private readonly IEscolaRepository _escolaRepository;

        public EscolaServices(IMapper mapper, IEscolaRepository escolaRepository)
        {
            _mapper = mapper;
            _escolaRepository = escolaRepository;
        }
     
        public void Salvar(EscolaDTos escolaDTo)
        {
            var escola = _mapper.Map<Escola>(escolaDTo);
            _escolaRepository.Salvar(escola);
        }
        public List<EscolaDTos> BuscarTodos()
        {
            var escolas = _escolaRepository.PegarTodos();
            return _mapper.Map<List<EscolaDTos>>(escolas);

        }
        public async Task<bool> Remover(long id)
        {
           return await _escolaRepository.Remover(id);
        }
        public Escola ObterPorId(long id)
        {
            return _escolaRepository.ObterPorId(id);
        }
    }

}
