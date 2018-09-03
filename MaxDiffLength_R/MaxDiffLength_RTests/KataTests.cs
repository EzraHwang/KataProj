using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxDiffLength_R;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxDiffLength_R.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void MaxDiffLengthTest()
        {
            string[] s1 =  { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
            string[] s2 =  { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
            Assert.AreEqual(13, Kata.MaxDiffLength(s1, s2));
        }
    }
}