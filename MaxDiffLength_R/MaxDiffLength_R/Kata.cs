using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxDiffLength_R
{
    public class Kata
    {
        public static int MaxDiffLength(string[] inputA, string[] inputB)
        {
            return inputA.Aggregate(-1, (current, t1) => inputB.Select(t => Math.Abs(t1.Length - t.Length)).Concat(new[] {current}).Max());
        }
    }
}
