using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaApi.Dto.KancelarijaDto;
using KancelarijaApi.Models;

namespace KancelarijaApi.Profiles
{
    public class KancelarijaProfile : Profile
    {
        public KancelarijaProfile()
        {
            CreateMap<Kancelarija, KancelarijaGetDto>();
            CreateMap<KancelarijaPostDto, Kancelarija>()
                .ForMember(x => x.ListaOsobe, y => y.Ignore());
            CreateMap<KancelarijaPutDto, Kancelarija>();
            CreateMap<Kancelarija, ListaOsobaDto>()
                .ForMember(x => x.OsobeUKancelariji, y => y.MapFrom(z => z.ListaOsobe));


           



        }
    }
}
