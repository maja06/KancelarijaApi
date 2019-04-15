using KancelarijaApi.Models;

namespace KancelarijaApi.Interfaces
{
    public interface IUredjajRepository : IRepository<Uredjaj, long>
    {
        Uredjaj KoriscenjeUredjaja(long id);

    }
}
