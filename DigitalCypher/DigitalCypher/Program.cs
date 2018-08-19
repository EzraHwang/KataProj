using System;

namespace DigitalCypher
{
    public class DigitalCypher
    {
        private static void Main(string[] args)
        {
            Console.Write(DigitalCypherFunc("masterpiece", 1939));
            Console.ReadKey();
        }

        public static int[] DigitalCypherFunc(string inputStr, int inputInt)
        {
            var anwser = new int[inputStr.Length];
            var keyNum = new int[inputInt.ToString().Length];
            for (var i = 0; i < keyNum.Length; i++)
            {
                keyNum[i] = (int) (inputInt / (Math.Pow(10, (keyNum.Length - i - 1))));
                inputInt = (int)(inputInt % (Math.Pow(10, (keyNum.Length - i - 1))));
            }
            var count = 0;
            var countKeyNum = 0;
            foreach (var s in inputStr.ToLower())
            {
                if (count >= keyNum.Length && count % keyNum.Length == 0)
                {
                    countKeyNum = 0;
                }
                anwser[count] = Convert.ToInt32(s) - 96 + keyNum[countKeyNum];
                count++;
                countKeyNum++;
            }

            return anwser;
        }
    }
}