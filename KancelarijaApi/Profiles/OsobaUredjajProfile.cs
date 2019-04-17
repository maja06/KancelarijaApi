using AutoMapper;
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
