using KancelarijaApi.Interfaces;
using KancelarijaApi.Models;
using KancelarijaApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KancelarijaApi.Repositories
{
    public class UredjajRepository : Repository<Uredjaj, long>, IUredjaj
    {
        private readonly KancelarijApiContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public UredjajRepository(KancelarijApiContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            context = _context;
            unitOfWork = _unitOfWork;
        }

        public void Add(Uredjaj entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Uredjaj entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Uredjaj> IRepository<Uredjaj, long>.GetAll()
        {
            throw new NotImplementedException();
        }

        Uredjaj IRepository<Uredjaj, long>.GetById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
