using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using KancelarijaApi.Dto.OsobaDto;
using KancelarijaApi.Dto.OsobaUredjajDto;
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
            CreateMap<Osoba, ListaKoriscenjaDto>()
                .ForMember(x => x.VrijemeKoriscenja, y => y.MapFrom(z => z.ListaKoriscenje));
            CreateMap<Osoba, OsobaInfoDto>();


        }
        
    }
}
