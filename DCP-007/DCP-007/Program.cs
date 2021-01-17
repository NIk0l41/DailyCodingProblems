using System;
using System.Linq;

namespace DCP_007
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 111;
            int[] digits = input.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            /* Source https://www.physicsforums.com/threads/converting-integer-into-array-of-single-digits-in-c.558588/ */
            int output = 0;
            for (int i = 0; i < digits.Length; i++) {
                if (digits[i] > 0){
                    output += Branch(digits, i);
                }
            }

            Console.WriteLine();
            Console.ReadLine();

        }

        static int Branch(int[] dig, int start) {
            int output = 0;
            for (int j = start; j < (dig.Length); j++) {
                if (((dig[j] * 10) + dig[j + 1]) < 27) {
                    output++;
                    output += Branch(dig, j);
                }
                output++;
            }
            return output;
        }
    }
}
