using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CoreTest1()
        {
            var one = 1;
            var two = 3;
            Assert.AreEqual(one, two);
            Assert.Pass();
        }
    }
}