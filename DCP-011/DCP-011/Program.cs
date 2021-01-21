using System;

namespace DCP_011
{
    class Program
    {
        static void Main(string[] args)
        {
            string pre = "s";
            string[] coll = {"snake", "spiral", "leprechaun", "spider" };
            return0(pre, coll);
            Console.ReadLine();
        }

        static void return0(string prefix, string[] collection) {
            string[] output = new string[collection.Length];
            for (int i = 0; i < collection.Length; i++) {
                if (collection[i].StartsWith(prefix)) {
                    Console.WriteLine(collection[i]);
                }
            }
        }
    }
}
