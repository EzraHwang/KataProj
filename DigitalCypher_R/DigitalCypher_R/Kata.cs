using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCypher_R
{
    public class Kata
    {
        public static int[] DigitalCypherFunc(string inputStr, int inputInt)
        {
            var anwser = new int[inputStr.Length];
            var keyNum = new int[inputInt.ToString().Length];
            GenerateKeyForAddingInputNum(inputInt, keyNum);
            AddingKeyToInputNum(inputStr, keyNum, anwser);
            return anwser;
        }

        private static void AddingKeyToInputNum(string inputStr, int[] keyNum, int[] anwser)
        {
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
        }

        private static void GenerateKeyForAddingInputNum(int inputInt, int[] keyNum)
        {
            for (var i = 0; i < keyNum.Length; i++)
            {
                keyNum[i] = (int) (inputInt / (Math.Pow(10, (keyNum.Length - i - 1))));
                inputInt = (int) (inputInt % (Math.Pow(10, (keyNum.Length - i - 1))));
            }
        }
    }
}
