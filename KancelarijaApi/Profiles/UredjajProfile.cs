using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaApi.Dto.UredjajDto;
using KancelarijaApi.Models;

namespace KancelarijaApi.Profiles
{
    public class UredjajProfile : Profile
    {
        public UredjajProfile()
        {
            CreateMap<Uredjaj, UredjajGetDto>();
            CreateMap<UredjajPostDto, Uredjaj>();
            CreateMap<UredjajPutDto, Uredjaj>();
            CreateMap<Uredjaj, KoriscenjeUredjajaDto>();


        }
    }
}
