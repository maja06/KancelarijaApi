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
            CreateMap<NovoKoriscenjeDto, OsobaUredjaj>();

        }
    }
}
