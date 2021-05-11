using System;
using Xunit;
using Moq;
using Microsoft.EntityFrameworkCore;
using Catalog.DAL.EF;
using Catalog.DAL.Entities;

namespace DAL.DAL.tests
{
    public class BaseRepositoryUnitTests
    {
        [Fact]
        public void Create_InputStreetInstance_CalledAddMethodOfDBSetWithStreetInstance()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<SweetFabContext>()
                .Options;
            var mockContext = new Mock<SweetFabContext>(opt);
            var mockDbSet = new Mock<DbSet<Sweet>>();
            mockContext
               .Setup(context =>
                    context.Set<Sweet>(
                        ))
                .Returns(mockDbSet.Object);
            var repository = new TestSweetRepository(mockContext.Object);
            Sweet expectedStreet = new Mock<Sweet>().Object;
            //Act
            repository.Create(expectedStreet);
    // Assert
    mockDbSet.Verify(
        dbSet => dbSet.Add(
            expectedStreet
            ), Times.Once());
        }
    }
}
