using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using KancelarijaApi.Dto.UredjajDto;
using KancelarijaApi.Models;
using KancelarijaApi.Interfaces;

namespace KancelarijaApi.Controllers
{
    [Route("api/Uredjaj")]
    public class UredjajController : BaseController<Uredjaj, UredjajGetDto, UredjajPostDto, UredjajPutDto, long>
    {
        private readonly IUredjajRepository _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
    


        public UredjajController(IUredjajRepository repository, IMapper mapper, IUnitOfWork unitOfWork ) : base(repository, mapper, unitOfWork)
                  
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = repository;
           
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


               
    


