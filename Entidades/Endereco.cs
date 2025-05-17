using System.ComponentModel.DataAnnotations;

namespace SenaiApi.Entidades
{
    public class Endereco : BaseEntity
    {
        public string Rua { get; set; }
        
        [MaxLength(80)]
        public string Bairro { get; set; }
       
        [MaxLength(50)]
        public string Cidade { get; set; }
        
        [MaxLength(60)]

        public string Estado { get; set; }
        
        [MaxLength(2)]
        public int Numero { get; set; }

        public long EscolaId {  get; set; }
        public Escola Escola { get; set; }
    }
}
