using System.ComponentModel.DataAnnotations;

namespace UoWRepository.Interface
{
    public record IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
