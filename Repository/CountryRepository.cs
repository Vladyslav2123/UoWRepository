using UoWRepository.Interface;
using UoWRepository.Models;

namespace UoWRepository.Repository
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(GameContext context) : base(context) { }
    }
}