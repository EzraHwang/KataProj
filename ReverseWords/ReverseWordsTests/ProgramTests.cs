using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseWords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void ReverseWordsTest()
        {
            Assert.AreEqual("sihT si na !elpmaxe", new TestProgram().ReverseWords("This is an example!"));
        }
    }
}