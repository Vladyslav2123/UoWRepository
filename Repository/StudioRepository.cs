using UoWRepository.Interface;
using UoWRepository.Models;

namespace UoWRepository.Repository
{
    public class StudioRepository : Repository<Studio>, IStudioRepository
    {
        public StudioRepository(GameContext context) : base(context) { }
    }
}
