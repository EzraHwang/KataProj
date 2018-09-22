using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace VowelCount.Tests
{
    [TestFixture]
    public class KataTests
    {
        [TestCase("qzwsxdcrfv", 0,Description = "qzwsxdcrfv_Result_Shoild_Be_0")]
        [TestCase("qwr  ty", 0, Description = "qwr  ty_Result_Shoild_Be_0")]
        [TestCase("aaaeeelsdkjf", 6, Description = "aaaeeelsdkjf_Result_Shoild_Be_6")]
        [TestCase("a e i o u", 5, Description = "a e i o u_Result_Shoild_Be_5")]
        [TestCase("a", 1, Description = "a_Result_Shoild_Be_1")]
        public void VowelTest(string input, int expected)
        {
            Assert.AreEqual(expected, new Kata().Vowel(input));
        }
    }
}