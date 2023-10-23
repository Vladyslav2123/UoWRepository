using AutoMapper;
using UoWRepository.Models;
using UoWRepository.Resource;

namespace UoWRepository.Mapper
{
    public class StudioProfile : Profile
    {
        public StudioProfile()
        {
            CreateMap<Studio, StudioResource>()
                .ForMember(t => t.Id, o => o.MapFrom(t => t.Id))
                .ForMember(t => t.StudioName, o => o.MapFrom(t => t.StudioName))
                .ForMember(t => t.CityId, o => o.MapFrom(t => t.CityId))
                .ForMember(t => t.City, o => o.MapFrom(t => t.City))
                .ForMember(t => t.Games, o => o.MapFrom(t => t.Games))
                .ReverseMap();
        }
    }
}