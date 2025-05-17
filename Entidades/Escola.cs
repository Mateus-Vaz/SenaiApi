using System.ComponentModel.DataAnnotations;

namespace SenaiApi.Entidades
{
    public class Escola : BaseEntity
    {
        [Required]
        [MaxLength(60)]
        public string Nome {  get; set; }
        public Endereco Endereco { get; set; }
        public List<Professor> Professores { get; set; }
        public List<Classe> Classes { get; set; }
    }
}
