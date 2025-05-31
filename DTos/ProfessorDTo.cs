using System.ComponentModel.DataAnnotations;

namespace SenaiApi.DTos
{
    public class ProfessorDTo
    {    
        public long Id { get; set; }
        [MaxLength(30)]
        public string Nome { get; set; }

        public long EscolaId { get; set; }

    }
}
    
    