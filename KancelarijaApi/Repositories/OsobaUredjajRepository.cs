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
    public class OsobaUredjajRepository : Repository<OsobaUredjaj, long>, IOsobaUredjaj
    {
        private readonly KancelarijApiContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public OsobaUredjajRepository(KancelarijApiContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            context = _context;
            unitOfWork = _unitOfWork;
        }

<<<<<<< HEAD
        //public IQueryable<OsobaUredjaj> IzlistavanjePoUredjaju(long id)
        //{
        //    return _context.OsobeUredjaji.Where(x => x.UredjajId == id).Include(o => o.Osoba).Include(u => u.Uredjaj);
        //}

=======
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
>>>>>>> 4df764ca067c34fc1b7063a3787d3a16e6b3798b
    }
}
