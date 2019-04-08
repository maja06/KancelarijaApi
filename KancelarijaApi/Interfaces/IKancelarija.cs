using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KancelarijaApi.Interfaces
{
    public interface IKancelarija : IRepository<Kancelarija, long>
    {
       // Kancelarija GetByName(string name);
        IQueryable<Kancelarija> GetKancelarijaPoImenu(string ime);
    }
}
