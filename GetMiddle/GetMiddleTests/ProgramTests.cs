using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetMiddle.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetMiddleTest()
        {    
            Assert.AreEqual("f", new TestProgram().GetMiddle("qwefqwe"));
            Assert.AreEqual("fc", new TestProgram().GetMiddle("qwefcqwe"));
            Assert.AreEqual("A", new TestProgram().GetMiddle("A"));
        }
    }
}