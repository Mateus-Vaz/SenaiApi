using System.ComponentModel.DataAnnotations;

namespace SenaiApi.Entidades
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }

    }
}
