using System;
using Xunit;

[Fact]
void Ctor_InputNull_ThrowArgumentNullException()
{
    // Arrange
    IUnitOfWork nullUnitOfWork = null;
​
    // Act
    // Assert
    Assert.Throws<ArgumentNullException>(
        () => new SweetService(nullUnitOfWork)
    );
}

internal class SweetService
{
    private IUnitOfWork nullUnitOfWork;

    public SweetService(IUnitOfWork nullUnitOfWork)
    {
        this.nullUnitOfWork = nullUnitOfWork;
    }
}

internal interface IUnitOfWork
{
}