using KancelarijaApi.Models;

namespace KancelarijaApi.Interfaces
{
    public interface IOsobaRepository : IRepository<Osoba, long>
    {
        Osoba ListaKoriscenjaPoOsobi(long id);
        Osoba IzlistajSve(long id);
    }
}
