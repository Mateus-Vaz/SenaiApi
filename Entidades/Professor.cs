using System.ComponentModel.DataAnnotations;

namespace SenaiApi.Entidades
{
    public class Professor : BaseEntity
    {
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }
        public Classe Classe { get; set; }

        public long EscolaId { get; set; }
        public Escola Escola { get; set; }

            
    }
}
