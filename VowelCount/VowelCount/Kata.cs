using System.Linq;

namespace VowelCount
{
    public class Kata
    {
        public int Vowel(string input)
        {
            //return input.Trim().Count(a => a == 'a') + input.Trim().Count(e => e == 'e') + input.Trim().Count(i => i == 'i') + input.Trim().Count(o => o == 'o') + input.Trim().Count(u => u == 'u');
            //refactor
            return input.Trim().Count(i => "aeiou".Contains(i));
        }
    }
}