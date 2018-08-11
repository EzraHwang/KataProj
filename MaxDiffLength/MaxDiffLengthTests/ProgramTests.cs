using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxDiffLength;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxDiffLength.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MaxDiffLengthTest()
        {
            string[] s1 = new string[] { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
            string[] s2 = new string[] { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
            Assert.AreEqual(13, MaxDiffLengthProgram.MaxDiffLength(s1, s2));
        }
    }
}