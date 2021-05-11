using System;
using Catalog.DAL.EF;
using Catalog.DAL.Entities;
using Catalog.DAL.Repositories.Interfaces;

namespace Catalog.DAL.Repositories.Impl
{
    public class SweetFabREpository
        : BaseRepository<SweetFab>, ISweetFabRepository
    {
        internal SweetFabREpository(SweetFabContext context)
            : base(context)
        {

        }
    }
}