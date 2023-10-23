using UoWRepository.Interface;
using UoWRepository.Models;

namespace UoWRepository.Repository
{
    public class GameRepository : Repository<Game>, IGameRepository
    {
        public GameRepository(GameContext context) : base(context) { }
    }
}
