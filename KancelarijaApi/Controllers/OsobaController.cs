using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using KancelarijaApi.Dto.OsobaDto;
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

        //[HttpPost]
        //public override IActionResult Post(OsobaPostDto input)
        //{
        //    using (var transaction = _context.Database.BeginTransaction())
        //    {
        //        if (input != null)
        //        {
        //            var mapOsoba = _mapper.Map<Osoba>(input);

        //            var osoba = new Osoba
        //            {
        //                Ime = mapOsoba.Ime,
        //                Prezime = mapOsoba.Prezime,
        //                KancelarijaId = mapOsoba.KancelarijaId
        //            };
        //            _context.Osobe.Add(osoba);
        //            _context.SaveChanges();

        //            var poslednjaOsoba = _context.Osobe.Last();
        //            var KancelarijaPoslednjeOsobe = poslednjaOsoba.KancelarijaId;

        //            var kancelarijaIme = _context.Kancelarije.FirstOrDefault(o => o.KancelarijaId == KancelarijaPoslednjeOsobe);


        //            var osobaList = kancelarijaIme.Osobe;
        //            osobaList.Add(osoba);
        //            transaction.Commit();

        //            return Ok();


        //        }
        //        return NotFound();
        //    }
        //}

        //[HttpPost]
        //public override IActionResult Post(OsobaPostDto input)
        //{
        //    using (var transaction = _context.Database.BeginTransaction())
        //    {
        //        var mapOsoba = _mapper.Map<Osoba>(input);
        //        var novaOsoba = new Osoba
        //        {
        //            Ime = input.Ime,
        //            Prezime = input.Prezime,
        //            KancelarijaId = input.KancelarijaId
        //        };

        //        _context.Add(novaOsoba);
        //        _context.SaveChanges();

        //        var idKancelarijaPoslednjeOsobe = novaOsoba.KancelarijaId;
        //        var lista = _context.Kancelarije.FirstOrDefault(x => x.KancelarijaId == idKancelarijaPoslednjeOsobe).ListaOsobe;
        //        var lista = kancelarije.ListaOsobe;

        //        lista.Add(novaOsoba);
        //        transaction.Commit();

        //        var poslednjaOsoba = _context.Osobe.Last();
        //        var idKancelarijaPoslednjeOsobe = poslednjaOsoba.KancelarijaId;
        //        var kancelarije = _context.Kancelarije.FirstOrDefault(x => x.KancelarijaId == idKancelarijaPoslednjeOsobe);
        //        var lista = kancelarije.ListaOsobe;

        //        lista.Add(novaOsoba);
        //        transaction.Commit();

        //        return Ok();
        //    }
        //}//napraviti metodu za vracanje liste osoba po kancelarijama

        //[HttpPut]
        //public override IActionResult Put(long id, OsobaPutDto input)
        //{
        //    using (var transaction = _context.Database.BeginTransaction())
        //    {
        //        var osoba = _context.Osobe.Find(id);
        //        if (osoba == null)
        //        {
        //            return NotFound();
        //        }

        //        var map = _mapper.Map(input, osoba);
        //        map.Ime = input.Ime;
        //        map.Prezime = input.Prezime;
        //        map.KancelarijaId = input.KancelarijaId;

        //        _context.SaveChanges();
        //        transaction.Commit();

        //        return Ok();
        //    }

        //}

        //[HttpDelete]
        //public override IActionResult Delete(long id)
        //{
        //    using (var transaction = _context.Database.BeginTransaction())
        //    {
        //        var osoba = _context.Osobe.Find(id);
        //        if (osoba == null) return NotFound();
        //        _context.Remove(osoba);
        //        _context.SaveChanges();
        //        transaction.Commit();

        //        return Ok($"Person with id: {id} successesfully deleted.");
        //    }

        //}
    }

}

