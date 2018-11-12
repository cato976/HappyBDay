using NUnit.Framework;

namespace Tests
{
    public class CoreUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
#if DEBUG
        [Ignore("Ignore for debug build")]
#endif
        public void CoreReleaseTest()
        {
            var one = 3;
            var two = 3;
            var result = 0;

            Assert.AreEqual(one, two);
            Assert.Pass();
        }

        [Test]
        public void CoreDebugTest()
        {
            var one = 3;
            var two = 3;
            var result = 0;

            Assert.AreEqual(one, two);
            Assert.Pass();
        }
    }
}
