using System;
using System.Linq;

namespace FindTheParityOutlier
{
    public class Kata
    {
        public int ParityOutlier(int[] input)
        {
            return input.Count(i => (Math.Abs(i) + 1) % 2 == 0) != 1
                ? input.First(i => (Math.Abs(i) + 2) % 2 == 0)
                : input.First(i => (Math.Abs(i) + 1) % 2 == 0);
        }
    }
}