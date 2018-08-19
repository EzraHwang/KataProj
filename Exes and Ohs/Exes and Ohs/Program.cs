using System.Linq;

namespace Exes_and_Ohs
{
    public class Exes_and_Ohs
    {
        private static void Main(string[] args)
        {
        }

        public static bool ExesAndOhs(string input)
        {
            return input.ToLower().Count(o => o == 'o') == input.ToLower().Count(x => x == 'x') ? true : false;
        }
    }
}