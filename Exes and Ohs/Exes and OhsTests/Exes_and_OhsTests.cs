using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exes_and_Ohs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exes_and_Ohs.Tests
{
    [TestClass()]
    public class Exes_and_OhsTests
    {
        [TestMethod()]
        public void ExesAndOhsTest()
        {
            Assert.AreEqual(true, Exes_and_Ohs.ExesAndOhs("xxxooo"));
            Assert.AreEqual(true, Exes_and_Ohs.ExesAndOhs("xxxXooOo"));
            Assert.AreEqual(false, Exes_and_Ohs.ExesAndOhs("xxx23424esdsfvxXXOOooo"));
            Assert.AreEqual(false, Exes_and_Ohs.ExesAndOhs("xXxxoewrcoOoo"));
            Assert.AreEqual(false, Exes_and_Ohs.ExesAndOhs("XxxxooO"));
            Assert.AreEqual(true, Exes_and_Ohs.ExesAndOhs("zssddd"));
            Assert.AreEqual(false, Exes_and_Ohs.ExesAndOhs("Xxxxertr34"));
        }
    }
}