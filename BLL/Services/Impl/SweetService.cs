using System;
using System.Collections.Generic;
using Catalog.BLL.DTO;
using Catalog.BLL.Services.Interfaces;
using Catalog.DAL.Entities;
using Catalog.DAL.UnitOfWork;

namespace Catalog.BLL.Services.Impl
{
    public class SweetService

        : ISweetService
    {
        private readonly IUnitOfWork _database;
        private int pageSize = 10;
​
        public SweetService( 
            IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            _database = unitOfWork;
        }
​
        /// <exception cref="MethodAccessException"></exception>
        public IEnumerable<SweetDTO> GetSweets(int pageNumber)
        {
            var user = SecurityContext.GetUser();
            var userType = user.GetType();
            if (userType != typeof(Director)
                && userType != typeof(Accountant))
            {
                throw new MethodAccessException();
            }
            var sweetfabId = User.SweetFabID;
            var sweetsEntities =
                _database
                    .Sweets
                    .Find(z => z.SweetFabID == sweetfabId, pageNumber, pageSize);
       

            var sweetsDto =
                cfg.Map<IEnumerable<Sweet>, List<SweetDTO>>(
                        sweetsEntities);
            yield return (SweetDTO)sweetsDto;
        }

        IEnumerable<SweetDTO> ISweetService.GetSweets(int page)
        {
            throw new System.NotImplementedException();
        }
    }

    internal class cfg
    {
        internal static object Map<T1, T2>(T1 sweetsEntities)
        {
            throw new NotImplementedException();
        }
    }

    internal class MapperConfiguration
    {
        private Func<object, object> p;

        public MapperConfiguration(Func<object, object> p)
        {
            this.p = p;
        }
    }

    internal class Accountant
    {
    }

    internal class Director
    {
    }

    internal class SecurityContext
    {
        internal static object GetUser()
        {
            throw new NotImplementedException();
        }
    }
}
