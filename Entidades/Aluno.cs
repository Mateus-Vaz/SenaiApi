using System.ComponentModel.DataAnnotations;

namespace SenaiApi.Entidades
{
    public class Aluno : BaseEntity
    {
        [Required]
        [MaxLength(60)]

        public string Nome {  get; set; }
        [Required]

        public DateTime Nascimento { get; set; }
        [Required]
        [MaxLength(14)]

        public string Cpf { get;set; }

        public long ClasseId { get; set; }
        public Classe Classe { get; set; }
    }
}
