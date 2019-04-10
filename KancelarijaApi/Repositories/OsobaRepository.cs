using KancelarijaApi.Interfaces;
using KancelarijaApi.Models;
using KancelarijaApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KancelarijaApi.Repositories
{
    public class OsobaRepository : Repository<Osoba, long>, IOsoba
    {
        private readonly KancelarijApiContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public OsobaRepository(KancelarijApiContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            _context = context ;
            _unitOfWork = unitOfWork;
        }

        public Osoba ListaKoriscenjaPoOsobi(long id)
        {
            var data = _context.Osobe.Include(x => x.ListaKoriscenje).FirstOrDefault(z => z.OsobaId == id);

            return data;
        }

        public Osoba IzlistajSve(long id)
        {
            var data = _context.Osobe.Include(x => x.Kancelarija).Include( x => x.ListaKoriscenje).Include(z => z.ListaUredjaji).FirstOrDefault( g => g.OsobaId == id);

            return data;
        }
   
      
        



    }
}
