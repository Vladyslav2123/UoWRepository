using UoWRepository.Models;

namespace UoWRepository.Resource
{
    public class CountryResource
    {
        public int Id { get; init; }

        public string? CountryName { get; init; }

        public List<City>? Cities { get; init; }
    }
}