using AutoMapper;
using UoWRepository.Models;
using UoWRepository.Resource;

namespace UoWRepository.Mapper
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryResource>()
                .ForMember(t => t.Id, o => o.MapFrom(t => t.Id))
                .ForMember(t => t.CountryName, o => o.MapFrom(t => t.CountryName))
                .ForMember(t => t.Cities, o => o.MapFrom(t => t.Cities))
                .ReverseMap();
        }
    }
}
