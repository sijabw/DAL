using System;
using Catalog.DAL.Entities;
using Catalog.DAL.Repositories.Impl;
using Catalog.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Catalog.DAL.EF
{
    public class EFUnitOfWork
    {
        private SweetFabContext db;
        private SweetFabRepository sweetFabRepository;
        private SweetRepository sweetRepository;

        public EFUnitOfWork(DbContextOptions options)
        {
            db = new SweetFabContext(options);
        }
        public IRepository<SweetFab> SweetFabs
        {
            get
            {
                if (sweetFabRepository == null)
                    sweetFabRepository = new SweetFabRepository(db);
                return (IRepository<SweetFab>)sweetFabRepository;
            }
        }

        public IRepository<Sweet> Sweets
        {
            get
            {
                if (sweetRepository == null)
                    sweetRepository = new SweetRepository(db);
                return sweetRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    internal class SweetFabRepository
    {
        private SweetFabContext db;

        public SweetFabRepository(SweetFabContext db)
        {
            this.db = db;
        }
    }
}

