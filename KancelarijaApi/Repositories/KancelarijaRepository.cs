using System;
using KancelarijaApi.Interfaces;
using KancelarijaApi.Models;
using KancelarijaApi.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using KancelarijaApi.Attributes;


namespace KancelarijaApi.Repositories
{
    [UniversalDi]
    public class KancelarijaRepository : Repository<Kancelarija, long>, IKancelarijaRepository
    {
        private readonly KancelarijApiContext _context;
        private readonly UnitOfWork _unitOfWork;

        public KancelarijaRepository(KancelarijApiContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            _context = context;
        }

        public Kancelarija ListaOsobaKancelarija(long id)
        {
            var data = _context.Kancelarije.Include(x => x.ListaOsobe).FirstOrDefault(x => x.KancelarijaId == id);

            return data;
        }

        public Kancelarija KancelarijaPoOpisu(string opis)
        {
            var data = _context.Kancelarije.Include(x => x.ListaOsobe).FirstOrDefault(y => y.Opis == opis);

            return data;
        }

        public override void Remove(long id)
        {
            var kancelarija = _context.Kancelarije.Find(id);
            if (kancelarija == null) throw new Exception("Not found.");
            if (kancelarija.ListaOsobe.Any()) throw new Exception();

            _context.Remove(kancelarija);
            _unitOfWork.Save();
        }




    }
}

