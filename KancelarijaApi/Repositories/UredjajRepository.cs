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
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public Uredjaj KoriscenjeUredjaja(long id)
        {
            var data = _context.Uredjaji.Include(x => x.ListaKoriscenje).Include(z => z.Osoba).FirstOrDefault(y => y.UredjajId == id);

            return data;


        }

        public void AddKoriscenje(OsobaUredjaj input)
        {
            //_unitOfWork.Start();
            var novoKoriscenje = new OsobaUredjaj { VrijemeOd = DateTime.Now };
            //var map = _mapper.Map<OsobaUredjaj>(input);
            var uredjajKoriscenje = _context.OsobeUredjaji
                .Where(a => a.VrijemeDo == null && a.UredjajId == input.UredjajId)
                .Select(b => b.OsobaUredjajId);
            var pronaciUredjajeKojiSeKoriste = _context.OsobeUredjaji.Find(uredjajKoriscenje.FirstOrDefault());
            if (uredjajKoriscenje.Count() != 0)
            {
                pronaciUredjajeKojiSeKoriste.VrijemeDo = DateTime.Now;
                _unitOfWork.Save();
            }
            if (input.UredjajId != 0 && input.OsobaId != 0)
            {
                novoKoriscenje.OsobaId = input.OsobaId;
                novoKoriscenje.UredjajId = input.UredjajId;
                _context.OsobeUredjaji.Add(novoKoriscenje);
                _unitOfWork.Save();
                // _unitOfWork.Commit();

            }

        }


    }
}
