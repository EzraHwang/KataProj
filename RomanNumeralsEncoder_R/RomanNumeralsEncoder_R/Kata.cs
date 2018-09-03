using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsEncoder_R
{
    public class Kata
    {
        public static string RomanNumeralsEncoder(int input)
        {
            var RomanSymbol_MCXI = new Dictionary<string, string> { { "M", "" }, { "C", "" }, { "X", "" }, { "I", "" } };
            var NineCheck = new Dictionary<string, string> { { "C", "CM" }, { "X", "XC" }, { "I", "IX" } };
            var FiveCheck = new Dictionary<string, string> { { "C", "D" }, { "X", "L" }, { "I", "V" } };
            var FourCheck = new Dictionary<string, string> { { "C", "CD" }, { "X", "XL" }, { "I", "IV" } };
            var romanRule = new Dictionary<int, string> { { 1000, "M" }, { 100, "C" }, { 10, "X" } };

            input = DividedInputByRomanRule(input, romanRule, RomanSymbol_MCXI);
            RomanLogicForDigits_I(input, RomanSymbol_MCXI);
            RomanLogicSeparator(RomanSymbol_MCXI.Keys.ToList(), RomanSymbol_MCXI, NineCheck, FiveCheck, FourCheck);
            return RomanSymbol_MCXI["M"] + RomanSymbol_MCXI["C"] + RomanSymbol_MCXI["X"] + RomanSymbol_MCXI["I"];
        }

        private static int DividedInputByRomanRule(int input, Dictionary<int, string> romanRule, Dictionary<string, string> RomanSymbol_MCX)
        {
            foreach (var romanItem in romanRule)
            {
                if (input < romanItem.Key) continue;
                for (var i = input; i >= romanItem.Key; i = i - romanItem.Key)
                {
                    RomanSymbol_MCX[romanItem.Value] = RomanSymbol_MCX[romanItem.Value] + romanItem.Value;
                    input = input - romanItem.Key;
                }
            }

            return input;
        }

        private static void RomanLogicForDigits_I(int input, Dictionary<string, string> MCX)
        {
            for (var i = 0; i < input; i++)
            {
                MCX["I"] = MCX["I"] + "I";
            }
        }

        private static void RomanLogicSeparator(List<string> outputType, Dictionary<string, string> MCX, Dictionary<string, string> NineCheck, Dictionary<string, string> FiveCheck,
            Dictionary<string, string> FourCheck)
        {
            for (var i = 0; i < outputType.Count; i++)
            {
                if (i == 0) continue;
                if (MCX[outputType[i]].Length == 9)
                {
                    MCX[outputType[i]] = NineCheck[outputType[i]];
                }
                else if (MCX[outputType[i]].Length >= 5)
                {
                    MCX[outputType[i]] =
                        MCX[outputType[i]].Replace(MCX[outputType[i]].Substring(0, 5), FiveCheck[outputType[i]]);
                }
                else if (MCX[outputType[i]].Length == 4)
                {
                    MCX[outputType[i]] = FourCheck[outputType[i]];
                }
            }
        }
    }
}