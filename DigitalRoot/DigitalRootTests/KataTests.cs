using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DigitalRoot.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void One_Six_Should_Return_Seven(int expect, int input)
        {
            Assert.AreEqual(7, new Kata().DigitalRoot(16));
        }

        [TestMethod()]
        public void Four_Five_Six_Should_Return_Six()
        {
            Assert.AreEqual(6, new Kata().DigitalRoot(456));
        }

        [TestMethod()]
        public void Nine_Nine_Nine_Nine_Should_Return_Nine()
        {
            Assert.AreEqual(9, new Kata().DigitalRoot(9999));
        }
    }
}