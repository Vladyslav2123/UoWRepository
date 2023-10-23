using UoWRepository.Interface;

namespace UoWRepository.Models
{
    public enum GameMode
    {
        singleplayer,
        multiplayer
    }

    public record Game : IEntity
    {
        public string Name { get; set; } = null!;

        public string Genre { get; set; } = null!;

        public string ReleaseDate { get; set; } = null!;

        public GameMode GetMode { get; set; }

        public int SoldCopies { get; set; }

        public int? StudioId { get; set; }

        public virtual Studio? Studio { get; set; }

    }
}
