using System;
using Catalog.DAL.EF;
using Catalog.DAL.Entities;
using Catalog.DAL.Repositories.Interfaces;

namespace Catalog.DAL.Repositories.Impl
{
    public class SweetRepository
            : BaseRepository<Sweet>, ISweetRepository
    {
        internal SweetRepository(SweetFabContext context)
            : base(context)
        {

        }
    }
}
