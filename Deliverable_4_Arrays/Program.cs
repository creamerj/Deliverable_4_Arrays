/*
 * Author: Jessica C
 * Date: 2/7/2023
 * Description: Fib. sequence displayed.
 * */

namespace Deliverable_4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fib = new int[25];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 0; i < fib.Length; i++)
            {
                if (i >= 2)
                {
                    fib[i] = fib[i - 1] + fib[i - 2];

                }
                Console.WriteLine("Fibonacci number (" + i + ") = " + fib[i]);
            }

        }
    }
}