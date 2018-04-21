using System;
using System.Collections.Generic;

namespace AverageString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write(AverageString("one two three four"));
            Console.ReadKey();
        }

        public static String AverageString(string input)
        {
            //dictionary
            var strToNum = StrToNum();
            //check is number
            //get number
            var inputArray = input.ToLower().Split(null);
            var answer = 0;

            //count
            foreach (var i in inputArray)
            {
                if (strToNum.ContainsKey(i) == true)
                {
                    answer = answer + strToNum[i];
                }
                else
                {
                    return "n/a";
                }
            }

            foreach (var i in strToNum)
            {
                if (i.Value == (answer / inputArray.Length))
                {
                    return i.Key;
                }
            }

            return "n/a";
        }

        private static Dictionary<string, int> StrToNum()
        {
            Dictionary<string, int> strToNum = new Dictionary<string, int>()
            {
                {"zero", 0},
                {"one", 1},
                {"two", 2},
                {"three", 3},
                {"four", 4},
                {"five", 5},
                {"six", 6},
                {"seven", 7},
                {"eight", 8},
                {"nine", 9},
            };
            return strToNum;
        }
    }
}