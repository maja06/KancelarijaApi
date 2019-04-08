using KancelarijaApi.Interfaces;
using KancelarijaApi.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KancelarijaApi
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly KancelarijApiContext _context;
        private IDbContextTransaction transaction;

        public UnitOfWork(KancelarijApiContext context)
        {
            _context = context;
        }

        public void Start()
        {
            this.transaction = _context.Database.BeginTransaction();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Dispose()
        {
            transaction?.Dispose();
        }
    }
}
