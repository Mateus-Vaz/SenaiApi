using SenaiApi.Entidades;

namespace SenaiApi.Repositorios.Interfaces
{
    public interface IProfessorRepository
    {
        public List<Professor> PegarTodos();

        void Salvar(Professor professor);

        Task<bool> Remover(long id);

        Professor ObterPorId(long id);
    }
}
