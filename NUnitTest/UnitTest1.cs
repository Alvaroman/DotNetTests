using Course_Project;
using Course_Project.Exceptions;
using Moq;
using NUnit.Framework;
using System;

namespace NUnitTest
{
    [TestFixture]
    public class Tests
    {
        private IMyTest _myTest;
        private Mock<IStack<int>> _stackMock;
        [SetUp]
        public void Setup()
        {
            _stackMock = new Mock<IStack<int>>();
            _myTest = new MyTest(_stackMock.Object);
        }

        [Test]
        [Ignore("Just becouse")]
        public void GetOneTest()
        {
            //Arrange
            var one = 1;

            //Act
            var expected = _myTest.GetNumberOne();

            Assert.AreEqual(one, expected, "Should be one.");
        }
        [Test]
        public void RamdonNumberTest()
        {
            //Arrange
            var one = 1;

            //Act
            var expected = _myTest.GetNumber();

            Assert.IsTrue(expected >= one, "Should be grater than 0.");
        }
        [Test]
        [TestCase(1)]
        public void GetManyOnesTest(int expectedResult)
        {
            var result = _myTest.GetNumberOne();

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetNumberTwoTest()
        {
            //Arrange
            var expected = 2;
            //Act
            var result = _myTest.GetNumberTwo();
            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        [TestCase("nss")]
        public void IsOneTest(object number)
        {

            //Arrange 
            var expected = number;

            //Act
            Assert.Throws<NotANumberException>(() => _myTest.IsOne(number));
        }
        [Test]
        public void GetEventTest()
        {
            var id = Guid.Empty;
            _myTest.Triggered += (sender, args) => { id = args; };
            _myTest.Event("testing");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }

        [Test]
        [TestCase("FizzBuzz", 15)]
        [TestCase("Fizz", 3)]
        [TestCase("Buzz", 10)]
        public void GetFizzBuzzTest(string expected, int number)
        {
            var result = _myTest.CalculateBuzz(number);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void RegisterStackTest()
        {
            var parameter = 1;
            _stackMock.Setup(x => x.Save(It.IsAny<int>())).Returns(1);

            var result = _myTest.RegisterStack(parameter);
            Assert.That(result, Is.EqualTo(parameter));
        }
    }
}