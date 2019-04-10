using KancelarijaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KancelarijaApi.Interfaces
{
    public interface IKancelarija : IRepository<Kancelarija, long>
    {
        Kancelarija ListaOsobaKancelarija(long id);
        Kancelarija KancelarijaPoOpisu(string opis);
    }
}
