using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using KancelarijaApi.Dto.OsobaUredjajDto;
using KancelarijaApi.Models;
using KancelarijaApi.Interfaces;

namespace KancelarijaApi.Controllers
{
    [Route("api/[controller]")]
    public class OsobaUredjajController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOsobaUredjajRepository _repository;
        


        public OsobaUredjajController(IMapper mapper, IOsobaUredjajRepository repository) 
        {
           
            _mapper = mapper;
            _repository = repository;

        }

       
        [HttpPost("Dodaj koriscenje")]
        public IActionResult PostKoriscenje(NovoKoriscenjeDto input)
        {
            var map = _mapper.Map<OsobaUredjaj>(input);
            _repository.AddKoriscenje(map);
            return Ok();
        }

      

    }
}
