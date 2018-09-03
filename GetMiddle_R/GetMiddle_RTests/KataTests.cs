using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetMiddle_R;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMiddle_R.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void GetMiddleTest_OneLetterInSentence()
        {
            Assert.AreEqual("A", new Kata().GetMiddle("A"));
        }
        [TestMethod()]
        public void GetMiddleTest_EvenLettersInSentence()
        {
            Assert.AreEqual("fc", new Kata().GetMiddle("qwefcqwe"));
        }
        [TestMethod()]
        public void GetMiddleTest_OddLettersInSentence()
        {
            Assert.AreEqual("f", new Kata().GetMiddle("qwefqwe"));
        }
    }
}