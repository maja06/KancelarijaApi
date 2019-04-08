using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using KancelarijaApi.Dto.OsobaDto;
using KancelarijaApi.Models;
using KancelarijaApi.Interfaces;

namespace KancelarijaApi.Controllers
{
    [Route("api/[controller]")]
    public class OsobaController : BaseController<Osoba, OsobaGetDto, OsobaPostDto, OsobaPutDto, long> 
    {
        private readonly IMapper _mapper;
        private readonly IOsoba _repository;
        private readonly IUnitOfWork _unitOfWork;


        public OsobaController(IMapper mapper, IOsoba repository, IUnitOfWork unitOfWork) : base(repository, mapper, unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = repository;

        }
                
    }

}

