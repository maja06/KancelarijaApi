using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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

        //[HttpPost("Novo koriscenje.")]
        //public IActionResult PostKoriscenje(NovoKoriscenjeDto input)
        //{
        //    using (var transaction = _context.Database.BeginTransaction())
        //    {                
        //        var novoKoriscenje = new OsobaUredjaj { VrijemeOd = DateTime.Now };
        //        var map = _mapper.Map<OsobaUredjaj>(input);

        //        var uredjajKoriscenje = _context.OsobeUredjaji
        //            .Where(a => a.VrijemeDo == null && a.UredjajId == map.UredjajId)
        //            .Select(b => b.OsobaUredjajId);

        //        var pronaciUredjajeKojiSeKoriste = _context.OsobeUredjaji.Find(uredjajKoriscenje.FirstOrDefault());
        //        if (uredjajKoriscenje.Count() != 0)
        //        {
        //            pronaciUredjajeKojiSeKoriste.VrijemeDo = DateTime.Now;
        //            _context.SaveChanges();
        //        }

        //        if(map.UredjajId != 0 && map.OsobaId != 0)
        //        {
        //            novoKoriscenje.OsobaId = map.OsobaId;
        //            novoKoriscenje.UredjajId = map.UredjajId;

        //            _context.OsobeUredjaji.Add(novoKoriscenje);
        //            _context.SaveChanges();
        //            transaction.Commit();
        //            return Ok(pronaciUredjajeKojiSeKoriste.ToString());

        //        }

        //        return BadRequest();
                                                                                 
        //    }
                
        //}

        //[HttpGet("Izlistati sve")]
        //public IActionResult GetSve()
        //{
        //    var osobauredjaj = _context.OsobeUredjaji.Include(x => x.Osoba);
           
        //    var lista = _mapper.ProjectTo<IstorijaDto>(osobauredjaj);

        //    if (lista.Any())
        //    {
        //        return Ok(osobauredjaj.Select(a => new { a.Osoba.Ime, a.Osoba.Prezime, a.Osoba.Kancelarija.Opis, a.Uredjaj.UredjajIme, a.VrijemeOd, a.VrijemeDo }));
        //    }

        //    return NotFound();
        //}

    }
}
