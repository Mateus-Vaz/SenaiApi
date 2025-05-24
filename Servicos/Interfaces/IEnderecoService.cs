using SenaiApi.DTos;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IEnderecoService  
    {
        List<EnderecoDTo> BuscarTodos();
        void Salvar(EnderecoDTo endereco);

        Task<bool> Remover(long id);
        void Editar(EnderecoDTo? endereco);
    }
}
