using Course_Project;
using NUnit.Framework;
namespace NUnitTest
{
    [TestFixture]
    public class StackTest
    {
        private IStack<int> _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new Stack<int>();
        }
        [Test]
        public void AddStackTest()
        {
            var value = 1;
            _stack.Save(value);
            var expected = _stack.Count;

            Assert.AreEqual(expected, value);
        }
        [Test]
        public void GetStackTest()
        {
            var expected = 1;
            _stack.Save(expected);
            var result = _stack.Get(0);

            Assert.AreEqual(expected, result);
        }

    }
}
