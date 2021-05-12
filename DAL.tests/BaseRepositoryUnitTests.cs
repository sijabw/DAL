using Catalog.DAL.Entities;
using Catalog.DAL.Repositories.Impl;
using Microsoft.EntityFrameworkCore;

class TestSweetRepository
    : BaseRepository < Sweet >
{
    public TestSweetRepository(DbContext context)
        : base(context)
    {
    }
}
