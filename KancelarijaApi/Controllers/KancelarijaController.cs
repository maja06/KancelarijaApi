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

        [HttpGet("Po Imenu")]
        public IActionResult GetKancelarijaPoImenu(string ime)
        {
            var kancelarijaIme = _repository.GetKancelarijaPoImenu(ime);
         
            var map = _mapper.Map<IEnumerable<IzlistavanjePoKancelarijiDto>>(kancelarijaIme);
           
            return Ok(map);
        }

        //[HttpGet("Liste osoba po kancelarijama.")]
        //public IActionResult GetOsobeUKancelarijama()
        //{
        //    return base.Ok(_context.Kancelarije.ProjectTo<ListaOsobaDto>(_mapper.ConfigurationProvider));

        //    //var osobeUKancelarijama = _context.Kancelarije
        //    //    .Include(x => x.ListaOsobe)
        //    //    .Select(a => new { Ime = a.Opis, ListaOsoba = a.ListaOsobe });
        //    //return Ok(osobeUKancelarijama.ToList());

        //    //var osobe = _context.Osobe.Include(k => k.Kancelarija).ThenInclude(l => l.ListaOsobe)
        //    //    .Select(a => new { a.Kancelarija.Opis, a.Kancelarija.ListaOsobe});
        //    //return Ok(osobe);
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

   

