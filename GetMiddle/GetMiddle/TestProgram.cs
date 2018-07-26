using System.Linq;

namespace GetMiddle
{
    public class TestProgram
    {
        private static void Main(string[] args)
        {
            //var input = Console.ReadLine();
            //var ans = GetMiddle(input);
            //Console.WriteLine("ans");
            //Console.Write(ans);
        }

        public string GetMiddle(string input)
        {
            if (input.Length == 1)
            {
                return input;
            }
            var inputSeparate = input.ToCharArray().Select(c => c.ToString()).ToArray();
            return inputSeparate.Length % 2 != 0
                ? inputSeparate[(inputSeparate.Length - 1) / 2]
                : inputSeparate[(inputSeparate.Length / 2 - 1)] + inputSeparate[(inputSeparate.Length / 2)];
        }
    }
}