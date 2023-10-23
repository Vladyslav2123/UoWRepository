using UoWRepository.Interface;
using UoWRepository.Repository;

namespace UoWRepository.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private GameContext _context;

        public UnitOfWork(GameContext context)
        {
            this._context = context;
            City = new CityRepository(this._context);
            Studio = new StudioRepository(this._context);
            Game = new GameRepository(this._context);
            Country = new CountryRepository(this._context);
        }

        public ICityRepository City { get; private set; }
        public IStudioRepository Studio { get; private set; }
        public IGameRepository Game { get; private set; }
        public ICountryRepository Country { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}