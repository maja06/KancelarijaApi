using KancelarijaApi.Interfaces;
using KancelarijaApi.Models;
using KancelarijaApi.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace KancelarijaApi.Repositories
{
    public class KancelarijaRepository : Repository<Kancelarija, long>, IKancelarija
    {
        private readonly KancelarijApiContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public KancelarijaRepository(KancelarijApiContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            context = _context;
            unitOfWork = _unitOfWork;
        }

      
        public IQueryable<Kancelarija> GetKancelarijaPoImenu(string ime)
        {
            var kancelarija = _context.Kancelarije.Where(o => o.Opis == ime).Include(n => n.ListaOsobe);
            if (!kancelarija.Any())
            {
               throw new Exception();
            }

            return kancelarija;

        }
    }
}
