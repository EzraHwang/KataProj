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
    [TestClass()]
    public class ProgramTests
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        public void RomanNumeralsEncoderTest(int input, string expected)
        {
            Assert.Equals(expected,RomanProgram.RomanNumeralsEncoder(input));
        }
    }
}