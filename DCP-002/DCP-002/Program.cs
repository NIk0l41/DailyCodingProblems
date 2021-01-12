using System;

namespace DCP_002
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 2, 1 };
            int[] b = sol2(a);
            for (int i = 0; i < a.Length; i++) {
                if (i == a.Length - 1){
                    Console.WriteLine(b[i]);
                }
                else {
                    Console.WriteLine(b[i] + ", ");
                }
            }
            Console.ReadLine();
        }
        
        /// <summary>
        /// Solution with Division
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int[] sol1(int[] a) {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++) {
                int k = 1;
                for (int j = 0; j < a.Length; j++) {
                    k *= a[j];
                }
                k /= a[i];
                b[i] = k;
            }
            return b;
        }

        /// <summary>
        /// Solution without Division
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int[] sol2(int[] a) {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++) {
                int k = 1;
                for (int j = 0; j < a.Length; j++) {
                    if (j != i) {
                        k *= a[j];
                    }
                }
                b[i] = k;
            }
            return b;
        }
    }
}
