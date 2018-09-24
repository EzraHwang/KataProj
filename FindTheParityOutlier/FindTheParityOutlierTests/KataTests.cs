using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace FindTheParityOutlier.Tests
{
    [TestFixture]
    public class KataTests
    {
        [TestCase(new[] { 2, 3, 5, 7, 9 }, 2, Description = "Even_In_Odds_return_Even")]
        [TestCase(new[] { 12, -13, 25, 37, 49 }, 12, Description = "Even_In_Odds_With_Negative_return_Even")]
        [TestCase(new[] { 1, 2, 4, 6, 8, 10 }, 1, Description = "Odd_In_Evens_return_Odd")]
        [TestCase(new[] { 91, 92, 2234, -4116, 6788, 310 }, 91, Description = "Odd_In_Evens_With_Negative_return_Odd")]
        public void ParityOutlierTest(int[] input, int expect)
        {
            Assert.AreEqual(expect,new Kata().ParityOutlier(input));
        }
    }
}