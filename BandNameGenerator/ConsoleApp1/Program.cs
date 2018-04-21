using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(bng("aabbcca"));
            Console.ReadKey();
        }

        public static string bng(string str)
        {
            if (str.Last() == str.First())
                return str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1) + str.Substring(1, str.Length - 1);
            return "The " + str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1);
    }
}