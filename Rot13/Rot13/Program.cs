using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Rot13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rot13 : ");
            String input = Console.ReadLine();
            Console.WriteLine(Rot13(input));

        }

        public static String Rot13(string input)
        {
            String Ans = "";

            for (int i = 0; i < input.Length; i++)
            {
                Ans = Ans + Transfer(input[i]).ToString();
                }

            return Ans;


        }

        public static char Transfer(Char character)
        {
            int AscNum = 0;
            Char output = 'A';

            AscNum = Convert.ToInt32(character);

            if (AscNum >= 65 && AscNum <= 90)
            {
                if (AscNum + 13 > 90)
                {
                    output = Convert.ToChar(AscNum - 13);
                }
                else
                    output = Convert.ToChar(AscNum + 13);
            }
            else if (AscNum >= 97 && AscNum <= 122)
            {
                if (AscNum + 13 > 122)
                {
                    output = Convert.ToChar(AscNum - 13);
                }
                else
                    output = Convert.ToChar(AscNum + 13);
            }
            else
                output = Convert.ToChar(AscNum);

            return output;
        }


    }
}
