using Course_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace MyUnitTests;
[TestClass]
public class MyTests
{
    private const int NUMBER_ONE = 1;
    IMyTest _mock = default!;

    [TestInitialize]
    public void Init()
    {
        _mock = Substitute.For<IMyTest>();
    }

    [TestMethod]
    public void Test1()
    {
        //Arrange
        _mock.GetNumberOne().Returns(NUMBER_ONE);
        //Act
        var myNumberOne = _mock.GetNumberOne();
        //Assert
        Assert.AreEqual(NUMBER_ONE, myNumberOne, "Should return 1.");

    }
}
