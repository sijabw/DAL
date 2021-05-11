using System;
using Catalog.DAL.EF;
using Catalog.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace DAL.DAL.tests
{
    public class Delete_InputId
    {
        [Fact]
public void Delete_InputId_CalledFindAndRemoveMethodsOfDBSetWithCorrectArg()
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
    Sweet expectedStreet = new Sweet() { SweetId = 1 };
    mockDbSet.Setup(mock => mock.Find(expectedStreet.SweetId))
             .Returns(expectedStreet);
    //Act
    repository.Delete(expectedStreet.SweetId);
    // Assert
    mockDbSet.Verify(
        dbSet => dbSet.Find(
            expectedStreet.SweetId
            ), Times.Once());
    mockDbSet.Verify(
        dbSet => dbSet.Remove(
            expectedStreet
            ), Times.Once());
}
}
}
