using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.BLL.Services.Interfaces;
using Xunit;

[Fact]
 void GetSweets_SweetFromDAL_CorrectMappingToSweetDTO()
{
    // Arrange
    User user = new Director(1, "test", 1);
    SecurityContext.SetUser(user);
    var sweetService = GetSweetService();
​
    // Act
    var actualSweetDto = sweetService.GetSweets(0).First();
​
    // Assert
    Assert.True(
        actualSweetDto.SweetId == 1
        && actualSweetDto.Name == "testN"
        && actualSweetDto.Description == "testD"
    );
}
​


ISweetService GetSweetService()
{
    var mockContext = new Mock<IUnitOfWork>();
    var expectedSweet = new Sweet() {
        SweetId = 1,
        Name = "testN",
        Description =     "testD"
    };
    var mockDbSet = new Mock<ISweetRepository>();
    mockDbSet
      .Setup(z =>
        z.Find(
            It.IsAny<Func<Sweet, bool>>(),
            It.IsAny<int>(),
            It.IsAny<int>()))
         .Returns(
             new List<Sweet>() { expectedSweet }
          );
    mockContext
        .Setup(context =>
            context.Sweets)
        .Returns(mockDbSet.Object);
​
    ISweetService sweetService = new SweetService(mockContext.Object);
​
    return sweetService;
}

internal class It
{
    internal static bool IsAny<T>()
    {
        throw new NotImplementedException();
    }
}

internal interface ISweetRepository
{
}

internal class Mock<T>
{
    public Mock()
    {
    }

    internal object Setup(Func<object, object> p)
    {
        throw new NotImplementedException();
    }
}

internal class Sweet
{
    public Sweet()
    {
    }

    public int SweetId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

internal class SecurityContext
{
    internal static void SetUser(User user)
    {
        throw new NotImplementedException();
    }
}

internal class Director : User
{
    private int v1;
    private string v2;
    private int v3;

    public Director(int v1, string v2, int v3)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
    }
}

internal class User
{
}