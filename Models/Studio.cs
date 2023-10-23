using UoWRepository.Interface;

namespace UoWRepository.Models
{
    public record Studio : IEntity
    {
        public string? StudioName { get; set; }

        public int? CityId { get; set; }

        public virtual City? City { get; set; }

        public virtual List<Game> Games { get; set; } = new List<Game>();
    }
}
