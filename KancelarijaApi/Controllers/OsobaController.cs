using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using KancelarijaApi.Dto.OsobaDto;
using KancelarijaApi.Dto.OsobaUredjajDto;
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

        [HttpGet("Lista svega")]
        public IActionResult GetIzlistajSve(long id)
        {
            var data = _repository.IzlistajSve(id);
            if (data == null)  return NotFound("Nema trazene osobe");

            var map = _mapper.Map<OsobaInfoDto>(data);

            return Ok(map);
        }

        [HttpGet("Lista koriscenja")]
        public IActionResult GetListaKoriscenja(long id)
        {
            var data = _repository.ListaKoriscenjaPoOsobi(id);

            if (data == null)
            {
                return NotFound("Nije pronadjena osoba");
            }

            var map = _mapper.Map<ListaKoriscenjaDto>(data);

            return Ok(map);
        }

       
                
    }

}

