using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExesAndOhs_R;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExesAndOhs_R.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void OAndXIsEqual()
        {
            Assert.AreEqual(true, Kata.ExesAndOhs("xxxooo"));
            Assert.AreEqual(true, Kata.ExesAndOhs("xxxXooOo"));
        }
        [TestMethod()]
        public void OAndXIsNotEqual()
        {
            Assert.AreEqual(false, Kata.ExesAndOhs("xxx23424esdsfvxXXOOooo"));
            Assert.AreEqual(false, Kata.ExesAndOhs("xXxxoewrcoOoo"));
            Assert.AreEqual(false, Kata.ExesAndOhs("XxxxooO"));
            Assert.AreEqual(false, Kata.ExesAndOhs("Xxxxertr34"));
        }
        [TestMethod()]
        public void NoOAndX()
        {
            Assert.AreEqual(true, Kata.ExesAndOhs("zssddd"));
        }
    }
}