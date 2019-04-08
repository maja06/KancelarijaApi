using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaApi.Dto.OsobaUredjajDto;
using KancelarijaApi.Models;

namespace KancelarijaApi.Profiles
{
    public class OsobaUredjajProfile : Profile
    {
        public OsobaUredjajProfile()
        {
            CreateMap<OsobaUredjaj, IstorijaDto>()
                .ForMember(a => a.OsobaIme, b => b.MapFrom(c => c.Osoba.Ime))
                .ForMember(a => a.OsobaPrezime, b => b.MapFrom(c => c.Osoba.Prezime))
                .ForMember(a => a.UredjajIme, b => b.MapFrom(c => c.Uredjaj.UredjajIme));

            CreateMap<NovoKoriscenjeDto, OsobaUredjaj>();

        }
    }
}
