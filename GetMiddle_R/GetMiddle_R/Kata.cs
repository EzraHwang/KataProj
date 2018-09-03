using System.Linq;

namespace GetMiddle_R
{
    public class Kata
    {
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