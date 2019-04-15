namespace KancelarijaApi.Interfaces
{
    public interface IUnitOfWork
    {
        void Save();
        void Start();
        void Commit();
        void Dispose();
        
    }
}
