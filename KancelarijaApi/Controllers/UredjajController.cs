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



        public UredjajController(IUredjaj repository, IMapper mapper, IUnitOfWork unitOfWork) : base(repository, mapper, unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = repository;
        }

        //    //[HttpGet]
        //    //public override IActionResult Get()
        //    //{
        //    //    var uredjaji = _context.Uredjaji.ProjectTo<UredjajGetDto>(_mapper.ConfigurationProvider);     

        //    //    if (null == uredjaji) return NoContent();
        //    //    return Ok(uredjaji);
        //    //}



    }

}
