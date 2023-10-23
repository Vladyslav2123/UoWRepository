namespace UoWRepository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ICityRepository City { get; }
        IStudioRepository Studio { get; }
        IGameRepository Game { get; }
        ICountryRepository Country { get; }
        void Save();
    }
}