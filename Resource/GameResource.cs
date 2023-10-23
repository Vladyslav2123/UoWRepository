using UoWRepository.Models;

namespace UoWRepository.Resource
{
    public class GameResource
    {
        public int Id { get; init; }

        public string? Name { get; init; }

        public string? Genre { get; init; }

        public string? ReleaseDate { get; init; }

        public GameMode GetMode { get; init; }

        public int SoldCopies { get; init; }

        public int? StudioId { get; init; }

        public Studio? Studio { get; init; }
    }
}
