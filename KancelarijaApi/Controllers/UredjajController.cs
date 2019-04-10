using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaApi.Dto.UredjajDto;
using KancelarijaApi.Models;
using KancelarijaApi.Interfaces;

namespace KancelarijaApi.Controllers
{
    [Route("api/Uredjaj")]
    public class UredjajController : BaseController<Uredjaj, UredjajGetDto, UredjajPostDto, UredjajPutDto, long>
    {
        private readonly IUredjaj _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
       // private readonly IOsobaUredjaj _koriscenje;



        public UredjajController(IUredjaj repository, IMapper mapper, IUnitOfWork unitOfWork /*,IOsobaUredjaj koriscenje*/) : base(repository, mapper, unitOfWork)
                  
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = repository;
            //_koriscenje = koriscenje;
        }

        [HttpGet("Koriscenje uredjaja")]
        public IActionResult GetUredjaj(long id)
        {
            var data = _repository.KoriscenjeUredjaja(id);

            if (data == null) return NotFound("Nema uredjaja sa trazenim Id-em");

            var map = _mapper.Map<KoriscenjeUredjajaDto>(data);

            return Ok(map);
        }




    }



}


               
    


