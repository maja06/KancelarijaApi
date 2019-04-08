using KancelarijaApi.Interfaces;
using KancelarijaApi.Models;
using KancelarijaApi.Repository;
using Microsoft.EntityFrameworkCore;
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

      

        
    }
}
