using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheOddInt
{
    public class Kata
    {
        public int Find_it(int[] input)
        {
            //return input.GroupBy(e => e).Where(e => e.Count() % 2 != 0).ToArray()[0].Key;
            //refactor
            return input.First(e => input.Count(c => c == e) % 2 != 0);
        }
    }
}
