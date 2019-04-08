using KancelarijaApi.Interfaces;
using KancelarijaApi.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KancelarijaApi.Repository
{
    public class Repository<TEntity, IdType> : IRepository<TEntity, IdType> where TEntity : class
    {
        private readonly KancelarijApiContext _context;
        private readonly IUnitOfWork _unitOfWork;
        
        public Repository(KancelarijApiContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            var entities = _context.Set<TEntity>().ToList();
            if(entities == null)
            {
                throw new Exception();
            }

            return entities;
        }

        public virtual TEntity GetById(IdType id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            //if (entity == null)
            //{
            //    throw new Exception("Not found.");
            //}

            return entity;
        }

        public virtual void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _unitOfWork.Save();
            
        }

        public virtual void Update(TEntity entity)
        {            
            _context.Set<TEntity>().Update(entity);
            _unitOfWork.Save();
        }

        public virtual void Remove(IdType id)
        {
            var found = _context.Set<TEntity>().Find(id);
            if (found == null)
            {
                throw new Exception("Not found.");
            }
            _context.Set<TEntity>().Remove(found);
            _unitOfWork.Save();
        }
    }
}
