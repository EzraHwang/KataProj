using System;
using System.Linq;

namespace ReverseWords
{
    public class TestProgram
    {
        public void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.Write(ReverseWords(input));
        }

        public string ReverseWords(string input)
        {
            var sentence = input.ToCharArray().Select(c => c.ToString()).ToArray();
            var ans = "";
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                ans = ans + sentence[i];
            }

            return ans;
        }
    }
}