using System;
using System.Collections.Generic;

namespace TwoSum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var inputList = Console.ReadLine();
            var target = Console.ReadLine();
            var output = twoSum(inputList, int.Parse(target));
            foreach (var number in output)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }

        private static IEnumerable<string> twoSum(string input, int target)
        {
            var inputs = input.Split(',');
            for (var i = 0; i < inputs.Length - 1; i++)
            {
                for (var j = i; j < inputs.Length; j++)
                {
                    if (int.Parse(inputs[i]) + int.Parse(inputs[j]) == target)
                    {
                        return new List<string> { inputs[i], inputs[j] };
                    }
                }
            }

            return null;
        }
    }
}