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
            _context = context;
            _unitOfWork = unitOfWork;
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

