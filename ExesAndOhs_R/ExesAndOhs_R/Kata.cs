using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExesAndOhs_R
{
    public class Kata
    {
        public static bool ExesAndOhs(string input)
        {
            return input.ToLower().Count(o => o == 'o') == input.ToLower().Count(x => x == 'x');
        }
    }
}
