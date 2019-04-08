using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using KancelarijaApi.Interfaces;
using System.Collections.Generic;

namespace KancelarijaApi.Controllers
{
    [Route("api/[controller]")]
    public class BaseController<TEntity, TGetDto, TPostDto, TPutDto, IdType> : ControllerBase where TEntity : class where TGetDto : class where TPostDto : class where TPutDto : class
    {
        private readonly IRepository<TEntity, IdType> _repository;
        private readonly IMapper _mapper;
        private readonly  IUnitOfWork _unitOfWork;

        public BaseController(IRepository<TEntity, IdType> repository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            var data = _repository.GetAll();

            if (data != null)
            {
                var otp = _mapper.Map<IEnumerable<TGetDto>>(data);

                return Ok(otp);
            }

            return NotFound("Nemaaaaa");
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(IdType id)
        {
            var data = _repository.GetById(id);

            if (data != null)
            {
                var otp = _mapper.Map<TGetDto>(data);

                return Ok(otp);
            }

            return NotFound("Nema");
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]TPostDto input)
        {
            var otp = _mapper.Map<TEntity>(input);
            _repository.Add(otp);
            _unitOfWork.Save();
            return Ok("Success");
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put(IdType id, TPutDto input)
        {
            var entity = _repository.GetById(id);
            _mapper.Map(input, entity);
            _unitOfWork.Save();
            
            return Ok("Success");
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(IdType id)
        {
            _repository.Remove(id);
            _unitOfWork.Save();
            return Ok("Success");
        }
    }
}
