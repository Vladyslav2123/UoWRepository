using AutoMapper;
using UoWRepository.Models;
using UoWRepository.Resource;

namespace UoWRepository.Mapper
{
    public class GameProfile : Profile
    {
        public GameProfile()
        {
            CreateMap<Game, GameResource>()
                .ForMember(t => t.Id, o => o.MapFrom(t => t.Id))
                .ForMember(t => t.Name, o => o.MapFrom(t => t.Name))
                .ForMember(t => t.Genre, o => o.MapFrom(t => t.Genre))
                .ForMember(t => t.GetMode, o => o.MapFrom(t => t.GetMode))
                .ForMember(t => t.ReleaseDate, o => o.MapFrom(t => t.ReleaseDate))
                .ForMember(t => t.SoldCopies, o => o.MapFrom(t => t.SoldCopies))
                .ForMember(t => t.StudioId, o => o.MapFrom(t => t.StudioId))
                .ForMember(t => t.Studio, o => o.MapFrom(t => t.Studio))
                .ReverseMap();
        }
    }
}