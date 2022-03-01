using System.ComponentModel.DataAnnotations;

namespace AS32.Domain.Base
{
    public class EntityBase
    {
        [Key]
        public long Id { get; set; }
    }
}