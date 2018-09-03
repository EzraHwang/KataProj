using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigitalCypher_R;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCypher_R.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void DigitalCypherFuncTest()
        {
            CollectionAssert.AreEqual(new[] { 20, 12, 18, 30, 21 }, Kata.DigitalCypherFunc("scout", 1939));
            CollectionAssert.AreEqual(new[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 }, Kata.DigitalCypherFunc("masterpiece", 1939));
        }
    }
}