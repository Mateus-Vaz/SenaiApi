using SenaiApi.Entidades;

namespace SenaiApi.Repositorios.Interfaces
{
    public interface IEnderecoRepository
    {
        public List<Endereco> PegarTodos();

        void Salvar(Endereco endereco);

        Task<bool> Remover(long id);

        Endereco ObterPorId(long id);
    }
}
