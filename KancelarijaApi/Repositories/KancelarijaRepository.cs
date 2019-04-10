using KancelarijaApi.Interfaces;
using KancelarijaApi.Models;
using KancelarijaApi.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace KancelarijaApi.Repositories
{
    public class KancelarijaRepository : Repository<Kancelarija, long>, IKancelarija
    {
        private readonly KancelarijApiContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public KancelarijaRepository(KancelarijApiContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
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

