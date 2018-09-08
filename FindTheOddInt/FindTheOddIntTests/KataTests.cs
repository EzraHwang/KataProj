using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindTheOddInt.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void Find_itTest()
        {
            Assert.AreEqual(5, new Kata().Find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }
    }
}