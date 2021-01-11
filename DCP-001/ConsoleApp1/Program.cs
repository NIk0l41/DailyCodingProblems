using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] n = { 10,15,3,7 };
            int k =17;
            Console.WriteLine(Check1(n, k));
            Console.ReadLine();
        }

        static bool Check1(int[] n, int k) {
            bool o = false;
            for (int i = 0; i < n.Length; i++) {
                for (int j = i + 1; j < n.Length; j++) {
                    if (n[i] + n[j] == k) {
                        o = true;
                        break;
                    }
                }
            }
            return o;
        }
    }
}
