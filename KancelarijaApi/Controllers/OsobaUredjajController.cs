using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaApi.Dto.OsobaDto;
using KancelarijaApi.Dto.OsobaUredjajDto;
using KancelarijaApi.Models;
using KancelarijaApi.Interfaces;
using Microsoft.AspNetCore.Routing;

namespace KancelarijaApi.Controllers
{
    [Route("api/[controller]")]
    public class OsobaUredjajController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOsobaUredjaj _repository;
        private readonly IUnitOfWork _unitOfWork;


        public OsobaUredjajController(IMapper mapper, IOsobaUredjaj repository, IUnitOfWork unitOfWork) 
        {
           _unitOfWork = unitOfWork;
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
