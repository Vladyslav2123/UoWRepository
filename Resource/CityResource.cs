using UoWRepository.Models;

namespace UoWRepository.Resource
{
    public class CityResource
    {
        public int Id { get; init; }

        public string? CityName { get; init; }

        public int? CountryId { get; init; }

        public Country? Country { get; init; }

        public List<Studio>? Studios { get; init; }
    }
}