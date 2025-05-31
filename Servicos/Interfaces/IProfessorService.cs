using SenaiApi.DTos;

namespace SenaiApi.Servicos.Interfaces
{
    public interface IProfessorService
    {
        
            List<ProfessorDTo> BuscarTodos();
            void Salvar(ProfessorDTo professor);

            Task<bool> Remover(long id);
            void Editar(ProfessorDTo? professor);
        }
    }

