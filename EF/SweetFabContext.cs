using System;
using Catalog.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalog.DAL.EF
{
    public class SweetFabContext
        : DbContext
    {
        public DbSet<SweetFab> Phones { get; set; }
        public DbSet<Sweet> Orders { get; set; }

        public SweetFabContext(DbContextOptions options)
            : base(options)
        {

        }
    }

}
