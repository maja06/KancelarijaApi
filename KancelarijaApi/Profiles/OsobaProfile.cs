using AutoMapper;
using KancelarijaApi.Dto.OsobaDto;
using KancelarijaApi.Models;

namespace KancelarijaApi.Profiles
{
    public class OsobaProfile : Profile
    {
        public OsobaProfile()
        {
            CreateMap<Osoba, OsobaGetDto>();
            CreateMap<OsobaPostDto, Osoba>();
            CreateMap<OsobaPutDto, Osoba>();
              
        }
        
    }
}
