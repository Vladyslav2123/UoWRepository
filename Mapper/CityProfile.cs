using AutoMapper;
using UoWRepository.Models;
using UoWRepository.Resource;

namespace UoWRepository.Mapper
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<City, CityResource>()
    .ForMember(t => t.Id, o => o.MapFrom(t => t.Id))
    .ForMember(t => t.CityName, o => o.MapFrom(t => t.CityName))
    .ForMember(t => t.Country, o => o.MapFrom(t => t.Country))
    .ForMember(t => t.CountryId, o => o.MapFrom(t => t.CountryId))
    .ForMember(t => t.Studios, o => o.MapFrom(t => t.Studios))
    .ReverseMap();
        }
    }
}
