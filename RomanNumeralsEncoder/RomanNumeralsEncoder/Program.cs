using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsEncoder
{
    public class RomanProgram
    {
        private static void Main(string[] args)
        {
            //Console.Write(RomanNumeralsEncoder(1954));
            //Console.ReadKey();
        }

        public static string RomanNumeralsEncoder(int input)
        {
            var MCX = new Dictionary<string, string> { { "M", "" }, { "C", "" }, { "X", "" }, { "I", "" } };
            var NineCheck = new Dictionary<string, string> { { "C", "CM" }, { "X", "XC" }, { "I", "IX" } };
            var FiveCheck = new Dictionary<string, string> { { "C", "D" }, { "X", "L" }, { "I", "V" } };
            var FourCheck = new Dictionary<string, string> { { "C", "CD" }, { "X", "XL" }, { "I", "IV" } };
            var romanRule = new Dictionary<int, string> { { 1000, "M" }, { 100, "C" }, { 10, "X" } };

            foreach (var romanItem in romanRule)
            {
                if (input < romanItem.Key) continue;
                lock (MCX)
                {
                    for (var i = input; i >= romanItem.Key; i = i - romanItem.Key)
                    {
                        MCX[romanItem.Value] = MCX[romanItem.Value] + romanItem.Value;
                        input = input - romanItem.Key;
                    }
                }
            }

            for (var i = 0; i < input; i++)
            {
                MCX["I"] = MCX["I"] + "I";
            }

            var outputType = MCX.Keys.ToList();

            for (var i = 0; i < outputType.Count; i++)
            {
                if (i == 0) continue;
                if (MCX[outputType[i]].Length == 9)
                {
                    MCX[outputType[i]] = NineCheck[outputType[i]];
                }
                else if (MCX[outputType[i]].Length >= 5)
                {
                    MCX[outputType[i]] = MCX[outputType[i]].Replace(MCX[outputType[i]].Substring(0, 5), FiveCheck[outputType[i]]);
                }
                else if (MCX[outputType[i]].Length == 4)
                {
                    MCX[outputType[i]] = FourCheck[outputType[i]];
                }
            }

            return MCX["M"] + MCX["C"] + MCX["X"] + MCX["I"];
        }
    }
}