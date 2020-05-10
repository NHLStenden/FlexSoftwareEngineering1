using System;
using System.Diagnostics;

namespace Recursion04
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();
            int counter = 0;
            for (int i = 1; i <= 100000; i++)
            {
                counter += IsPrimeNumberHelperSlow(i) ? 1 : 0;
            }
            long  elapsedMilliseconds = sw.ElapsedMilliseconds;

            Console.WriteLine("Gevonden priemgetallen : {0} in {1}ms", counter, elapsedMilliseconds);
            
            sw = Stopwatch.StartNew();
            counter = 0;
            for (int i = 1; i <= 100000; i++)
            {
                counter += IsPrimeNumberHelperFast(i) ? 1 : 0;
            }
            elapsedMilliseconds = sw.ElapsedMilliseconds;

            Console.WriteLine("Gevonden priemgetallen : {0} in {1}ms", counter, elapsedMilliseconds);

        }

        static bool IsPrimeNumberHelperFast(int n)
        {
            return IsPrimeNumberFast(n, 2);
        }
        static bool IsPrimeNumberHelperSlow(int n)
        {
            return IsPrimeNumberSlow(n, 2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="divider"></param>
        /// <returns></returns>
        static bool IsPrimeNumberFast(int n, int divider)
        {
            if (n == 1) return true;
            if (n == 2) return false;

            if (n % divider == 0) return false;
            
            if (divider * divider > n) return true;

            //if (n / 2 < divider ) return true;

            return IsPrimeNumberFast(n, divider + 1);

        }
        static bool IsPrimeNumberSlow(int n, int divider)
        {
            if (n == 1) return true;
            if (n == 2) return false;

            if (n % divider == 0) return false;
            
            if (n / 2 < divider ) return true;

            return IsPrimeNumberSlow(n, divider + 1);

        }    }
}