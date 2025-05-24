using SenaiApi.Entidades;
using System.ComponentModel.DataAnnotations;

namespace SenaiApi.DTos
{
    public class EnderecoDTo
    {
        public long Id { get; set; }
        public string Rua { get; set; }

        [MaxLength(80)]
        public string Bairro { get; set; }

        [MaxLength(50)]
        public string Cidade { get; set; }

        [MaxLength(60)]

        public string Estado { get; set; }

        public int Numero { get; set; }

        public long EscolaId { get; set; }
       
    }
}