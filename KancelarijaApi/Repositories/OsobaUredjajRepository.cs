using KancelarijaApi.Interfaces;
using KancelarijaApi.Models;
using KancelarijaApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KancelarijaApi.Repositories
{
    public class OsobaUredjajRepository : Repository<OsobaUredjaj, long>, IOsobaUredjaj
    {
        private readonly KancelarijApiContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public OsobaUredjajRepository(KancelarijApiContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            context = _context;
            unitOfWork = _unitOfWork;
        }

        public void Add(IOsobaUredjaj entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IOsobaUredjaj entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IOsobaUredjaj> IRepository<IOsobaUredjaj, long>.GetAll()
        {
            throw new NotImplementedException();
        }

        IOsobaUredjaj IRepository<IOsobaUredjaj, long>.GetById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
