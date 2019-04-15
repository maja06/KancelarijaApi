using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using KancelarijaApi.Interfaces;
using System.Collections.Generic;

namespace KancelarijaApi.Controllers
{
    [Route("api/[controller]")]
    public abstract class BaseController<TEntity, TGetDto, TPostDto, TPutDto, TIdType> : ControllerBase where TEntity : class where TGetDto : class where TPostDto : class where TPutDto : class
    {
        private readonly IRepository<TEntity, TIdType> _repository;
        private readonly IMapper _mapper;
        private readonly  IUnitOfWork _unitOfWork;

        public BaseController(IRepository<TEntity, TIdType> repository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/<controller>
        [HttpGet]
        public virtual IActionResult Get()
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
        public virtual IActionResult Get(TIdType id)
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
        public virtual IActionResult Post([FromBody]TPostDto input)
        {
            var otp = _mapper.Map<TEntity>(input);
            _repository.Add(otp);
            _unitOfWork.Save();
            return Ok("Success");
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public virtual IActionResult Put(TIdType id, TPutDto input)
        {
            var entity = _repository.GetById(id);
            _mapper.Map(input, entity);
            _unitOfWork.Save();
            
            return Ok("Success");
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public virtual IActionResult Delete(TIdType id)
        {
            _repository.Remove(id);
            _unitOfWork.Save();
            return Ok("Success");
        }
    }
}
