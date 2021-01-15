using System;

namespace DCP_005{

    internal class Program{

        private static void Main(string[] args){
            cons pair = new cons(3, 4);
            Console.WriteLine(pair.a + ", " + pair.b);
            Console.WriteLine("---");
            Console.WriteLine(car(pair));
            Console.WriteLine(cdr(pair));
            Console.ReadLine();
        }

        private static int car(cons c){
            return c.a;
        }

        private static int cdr(cons c){
            return c.b;
        }
    }

    internal class cons{
        public int a;
        public int b;

        public cons(int a, int b){
            this.a = a;
            this.b = b;
        }
    }
}