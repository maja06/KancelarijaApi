using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
