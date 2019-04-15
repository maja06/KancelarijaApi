using KancelarijaApi.Interfaces;
using KancelarijaApi.Models;
using KancelarijaApi.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace KancelarijaApi.Repositories
{
    public class UredjajRepository : Repository<Uredjaj, long>, IUredjajRepository
    {
        private readonly KancelarijApiContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public UredjajRepository(KancelarijApiContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public Uredjaj KoriscenjeUredjaja(long id)
        {
            var data = _context.Uredjaji.Include(x => x.ListaKoriscenje).Include(z => z.Osoba).FirstOrDefault(y => y.UredjajId == id);

            return data;


        }

        
            


    }
}
