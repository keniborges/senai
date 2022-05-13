using System.ComponentModel.DataAnnotations;

namespace BigData.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
