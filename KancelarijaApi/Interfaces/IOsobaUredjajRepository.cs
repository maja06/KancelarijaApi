using KancelarijaApi.Models;

namespace KancelarijaApi.Interfaces
{

    public interface IOsobaUredjajRepository : IRepository<OsobaUredjaj, long>
    {
        
        void AddKoriscenje(OsobaUredjaj input);


    }
}
