using System.Linq;

namespace Persistent_Bugger
{
    public class Kata
    {
        public int Persistence(int input)
        {
            var check = 0;
            var array = input.ToString().Select(o => (o - '0')).ToArray();
            for (var i = 0; i < array.Length; i++)
            {
                input = i == 0 ? array[i] : input * array[i];
                check++;
            }

            if (check == 1 && input < 10)
            {
                return 0;
            }
            return input > 10 ? Persistence(input) : input;
        }
    }
}