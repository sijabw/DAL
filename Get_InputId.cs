using System;
using Catalog.DAL.EF;
using Catalog.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace DAL.DAL.tests
{
    public class _7
    { 
 [Fact]
public void Get_InputId_CalledFindMethodOfDBSetWithCorrectId()
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
