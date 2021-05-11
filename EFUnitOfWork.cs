using System;
using Catalog.DAL.Repositories.Interfaces;

namespace Catalog.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ISweetFabRepository SweetFabs { get; }
        ISweetRepository Sweets { get; }
        void Save();
    }
}