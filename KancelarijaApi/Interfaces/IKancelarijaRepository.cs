namespace KancelarijaApi.Interfaces
{
    public interface IKancelarijaRepository : IRepository<Kancelarija, long>
    {
        Kancelarija ListaOsobaKancelarija(long id);
        Kancelarija KancelarijaPoOpisu(string opis);
    }
}
