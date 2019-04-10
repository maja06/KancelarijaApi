using KancelarijaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace KancelarijaApi.Interfaces
{
    public interface IOsoba : IRepository<Osoba, long>
    {
        Osoba ListaKoriscenjaPoOsobi(long id);
        Osoba IzlistajSve(long id);
    }
}
