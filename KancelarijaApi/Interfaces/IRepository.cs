using System.Collections.Generic;

namespace KancelarijaApi.Interfaces
{
    public interface IRepository<TEntity, IdType> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(IdType id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(IdType id);

    }
}
