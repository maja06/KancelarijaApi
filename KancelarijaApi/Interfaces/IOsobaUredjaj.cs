using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KancelarijaApi.Models;

namespace KancelarijaApi.Interfaces
{

    public interface IOsobaUredjaj : IRepository<OsobaUredjaj, long>
    {
       // IQueryable<OsobaUredjaj> IzlistavanjePoUredjaju(long id);
        void AddKoriscenje(OsobaUredjaj input);


    }
}
