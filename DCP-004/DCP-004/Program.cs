using System;

namespace DCP_004
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input Array
            int[] a = { -3,0,1,3 };

            //Output Integer
            int p = 0;

            int[] tmp = a;
            Array.Sort(tmp); //Sorts the array from smallest to largest.

            for (int i = 0; i < a.Length; i++) {
                write(a[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("-----");
            if (tmp.Length != 1) {

                //Dispose of Negative Numbers//
                tmp = Array.FindAll(tmp, isPositive);
                if (tmp.Length > 0){
                    if (tmp.Length != 1) {
                /*The two conditions above just verify that we have an array that has a length of 2 or more items,
                    Since that's where this algorithm takes place.*/
                        if (tmp[0] != 1){ /*If the first item that is positive is not a '1', then the gap is located at '1'*/
                            p = 1;
                        }
                        else { //But if it's not, we run this.
                            for (int i = 0; i < tmp.Length; i++) { /*Essentially we are running through every number in
                                the array to determine whether there is any gap in between the numbers.*/
                                int c = i + 1;
                                if (tmp[i] != c) {
                                    /*If a gap is found, then we have our lowest number we can generate! So we break
                                     *and let the program print out the result*/
                                    p = c;
                                    break;
                                }
                            }
                            if (p == 0) { p = tmp.Length + 1; }/*However, if no gap is found in the entire array, 
                            then the lowest number we can generate is the one after the highest one.*/
                        }

                    }
                    else{
                        //If the array has a length of 1, we check to see what gaps exist, then declare what it is.
                        //Luckily, there can't be many gaps with a singular block.
                        if (tmp[0] > 1) { p = 1; }
                        else{
                            if (tmp[0] == 1) { p = 2; }
                        }
                    }
                }
                else {/*And if for some ungodly reason, the entire array was NEGATIVE, well, the
                    lowest positive integer possible is '1'*/
                    p = 1;
                }
            }
            else {
            }

            Console.WriteLine(p);
            Console.ReadLine();
        }

        static bool isPositive(int n) {
            return (n > 0);
        }

        static void write(object a) {
            Console.Write(a.ToString() + ", ");
        }

        static void wait() {
            Console.ReadLine();
        }
    }
}
