using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistent_Bugger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistent_Bugger.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void PersistenceTest_ONES()
        {
            Assert.AreEqual(0, new Kata().Persistence(4));
        }

        [TestMethod()]
        public void PersistenceTest_TENS()
        {
            Assert.AreEqual(4, new Kata().Persistence(39));
        }

        [TestMethod()]
        public void PersistenceTest_HUNDRES()
        {
            Assert.AreEqual(2, new Kata().Persistence(999));

        }

    }
}