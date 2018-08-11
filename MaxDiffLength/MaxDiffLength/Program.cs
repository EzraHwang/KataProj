using System;

namespace MaxDiffLength
{
    public class MaxDiffLengthProgram
    {
        private static void Main(string[] args)
        {
        }

        public static int MaxDiffLength(string[] inputA, string[] inputB)
        {
            var ans = -1;
            for (var a = 0; a < inputA.Length; a++)
            {
                for (var b = 0; b < inputB.Length; b++)
                {
                    if (Math.Abs(inputA[a].Length - inputB[b].Length) > ans)
                    {
                        ans = Math.Abs(inputA[a].Length - inputB[b].Length);
                    }
                }
            }

            return ans;
        }
    }
}