using UoWRepository.Models;

namespace UoWRepository.Resource
{
    public class StudioResource
    {
        public int Id { get; init; }

        public string? StudioName { get; init; }

        public int? CityId { get; init; }

        public City? City { get; init; }

        public List<Game>? Games { get; init; }
    }
}