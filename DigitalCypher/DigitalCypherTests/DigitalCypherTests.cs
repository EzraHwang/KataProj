using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DigitalCypher.Tests
{
    [TestClass()]
    public class DigitalCypherTests
    {
        [TestMethod()]
        public void DigitalCypherFuncTest()
        {
            CollectionAssert.AreEqual(new[] { 20, 12, 18, 30, 21 }, DigitalCypher.DigitalCypherFunc("scout", 1939));
            CollectionAssert.AreEqual(new[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 }, DigitalCypher.DigitalCypherFunc("masterpiece", 1939));
        }
    }
}