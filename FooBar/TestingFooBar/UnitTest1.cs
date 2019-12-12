using NUnit.Framework;
using FooBar;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        Program pr = null;

        [SetUp]
        void SetUp()
        {
            pr = new Program();
        }

        [Test]
        [TestCase(33)]
        public void TestFooBarQix(int number)
        {
            string expected = "FooFooFoo";
            string actual = pr.FooBarKata(number);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(0)]
        public void TestFooBarForZeroValue(int number)
        {
            string expected = "Number can not be zero or lower";
            string actual = pr.FooBarKata(number);

            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        void Disposing()
        {
            pr = null;
        }
    }
}