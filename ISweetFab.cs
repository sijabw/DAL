using System;
using System.Collections.Generic;

namespace Catalog.DAL.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetALL();
        T Get(int id);
        IEnumerable<T> Find(Func<T, Boolean> predicate);
        void Create(T item);
        void Update(T item);
        void Delete(T item);
        IEnumerable<T> Find(Func<T, bool> predicate, int pageNumber = 0, int pageSize = 10);
    }
}
