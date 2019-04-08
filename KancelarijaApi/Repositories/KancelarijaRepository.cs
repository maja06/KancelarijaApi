using KancelarijaApi.Interfaces;
using KancelarijaApi.Models;
using KancelarijaApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


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

        public Kancelarija GetByName(string name)
        {
            var found = _context.Kancelarije.Where(a => a.Opis == name).FirstOrDefault();
            if (found == null)
            {
                throw new Exception();
            }
            return found;

        }
    }
}
