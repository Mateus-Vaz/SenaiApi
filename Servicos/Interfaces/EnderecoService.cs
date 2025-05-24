using AutoMapper;
using SenaiApi.DTos;
using SenaiApi.Entidades;
using SenaiApi.Repositorios;
using SenaiApi.Repositorios.Interfaces;
using SenaiApi.Servicos.Interface.cs;

namespace SenaiApi.Servicos.Interfaces
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IMapper mapper, IEnderecoRepository enderecoRepository)
        {
            _mapper = mapper;
            _enderecoRepository = enderecoRepository;
        }

        public void Salvar(EnderecoDTo enderecoDTo)
        {
            var endereco = _mapper.Map<Endereco>(enderecoDTo);
            _enderecoRepository.Salvar(endereco);
        }
        public List<EnderecoDTo> BuscarTodos()
        {
            var enderecos = _enderecoRepository.PegarTodos();
            return _mapper.Map<List<EnderecoDTo>>(enderecos);

        }
        public void Editar(EnderecoDTo model)
        {
            var endereco = _enderecoRepository.ObterPorId(model.Id);
            _mapper.Map(model, endereco);

            _enderecoRepository.Salvar(endereco);
        }
        public async Task<bool> Remover(long id)
        {
            return await _enderecoRepository.Remover(id);
        }
    }
}

