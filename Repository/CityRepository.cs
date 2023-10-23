using UoWRepository.Interface;
using UoWRepository.Models;

namespace UoWRepository.Repository
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(GameContext context) : base(context) { }
    }
}
