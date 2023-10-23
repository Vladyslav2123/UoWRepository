using UoWRepository.Interface;

namespace UoWRepository.Models
{
    public record City : IEntity
    {
        public string? CityName { get; set; }

        public int? CountryId { get; set; }

        public virtual Country? Country { get; set; }

        public virtual List<Studio> Studios { get; set; } = new List<Studio>();
    }
}