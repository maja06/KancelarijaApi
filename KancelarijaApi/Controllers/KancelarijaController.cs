using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using KancelarijaApi.Dto.KancelarijaDto;
using KancelarijaApi.Models;
using KancelarijaApi.Interfaces;

namespace KancelarijaApi.Controllers
{
    [Route("api/[controller]")]
    public class KancelarijaController : BaseController<Kancelarija, KancelarijaGetDto, KancelarijaPostDto, KancelarijaPutDto, long>
    {
        private readonly IMapper _mapper;
        private readonly IKancelarija _repository;
        private readonly IUnitOfWork _unitOfWork;
        

        public KancelarijaController(IMapper mapper, IKancelarija repository, IUnitOfWork unitOfWork) : base(repository, mapper, unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = repository;

        }

        [HttpGet("Osobe u kancelariji")]
        public IActionResult GetLista(long id)
        {
            var data = _repository.ListaOsobaKancelarija(id);

            var map = _mapper.Map<ListaOsobaDto>(data);

            return Ok(map);
        }

        [HttpGet("Osobe kancelariji")]
        public IActionResult GetKncelarija(string opis)
        {
            var kancelarija = _repository.KancelarijaPoOpisu(opis);

            if (opis == null) return NotFound("Nema kancelarije sa trazenim opisom");

            if (!kancelarija.ListaOsobe.Any()) return Ok("Kancelarija nema osobu");

            var map = _mapper.Map<ListaOsobaDto>(kancelarija);
        
            return Ok(map);
        }

       

        //[HttpDelete("Obrisati kancelariju ali ne i osobu")]
        //public IActionResult DeleteKancelariju(long id)
        //{
        //    var kancelarija = _repository.Get(id);

        //    if(kancelarija == null) return NotFound("Kancelarija sa datim Id-em ne postoji")

        //    if(!kancelarija.Osoba.Any()) 
        //}



        //[HttpDelete]
        //public override IActionResult Delete(long id)
        //{
        //    using(var transaction = _context.Database.BeginTransaction())
        //    {
        //        var kancelarija = _context.Kancelarije.Find(id);
        //        if (kancelarija == null) return NotFound();

        //        var brojOsobaUKancelariji = kancelarija.ListaOsobe;
        //        if (brojOsobaUKancelariji.Count() != 0) return BadRequest();


        //        //if (kancelarija.ListaOsobe != null) return BadRequest($"You cannot delete office with {id} because there are still people in that office.");

        //        _context.Remove(kancelarija);

        //        _context.SaveChanges();
        //        transaction.Commit();

        //        return Ok();
        //    }

    }
  }

   

