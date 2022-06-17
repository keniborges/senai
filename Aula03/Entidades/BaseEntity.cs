using System.ComponentModel.DataAnnotations;

namespace Aula03.Entidades
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
