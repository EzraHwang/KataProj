using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsEncoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace RomanNumeralsEncoder.Tests
{
    [TestFixture]
    public class RomanProgramTests
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        [TestCase(500, "D")]
        [TestCase(1000, "M")]
        [TestCase(1954, "MCMLIV")]
        [TestCase(1990, "MCMXC")]
        [TestCase(2008, "MMVIII")]
        [TestCase(2014, "MMXIV")]
        public void RomanNumeralsEncoderTest(int input, string expected)
        {
            Assert.AreEqual(expected, RomanProgram.RomanNumeralsEncoder(input));
        }
    }
}