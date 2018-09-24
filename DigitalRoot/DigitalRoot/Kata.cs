using System.Linq;

namespace DigitalRoot
{
    public class Kata
    {
        public int DigitalRoot(int input)
        {
            input = input.ToString().ToCharArray().Aggregate(0, (current, i) => (int) i - 48 + current);
            return input > 10 ? DigitalRoot(input) : input;
        }
    }
}