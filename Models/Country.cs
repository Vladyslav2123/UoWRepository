using UoWRepository.Interface;

namespace UoWRepository.Models
{
    public record Country : IEntity
    {
        public string? CountryName { get; set; }

        public virtual List<City> Cities { get; set; } = new List<City>();
    }
}
