using System;
using System.Diagnostics;

namespace Recursion04
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new stopwatch to measure time
            var sw = Stopwatch.StartNew();

            // init counter to zero: the number of found prime-numbers
            int counter = 0;

            // go searching using a slow function
            for (int i = 1; i <= 100000; i++)
            {
                counter += IsPrimeNumberHelperSlow(i) ? 1 : 0;
            }

            long elapsedMilliseconds = sw.ElapsedMilliseconds;

            // report results
            Console.WriteLine("Gevonden priemgetallen : {0} in {1}ms", counter, elapsedMilliseconds);

            // repeat with fast function
            sw = Stopwatch.StartNew();
            counter = 0;
            for (int i = 1; i <= 100000; i++)
            {
                counter += IsPrimeNumberHelperFast(i) ? 1 : 0;
            }

            elapsedMilliseconds = sw.ElapsedMilliseconds;

            Console.WriteLine("Gevonden priemgetallen : {0} in {1}ms", counter, elapsedMilliseconds);
        } // Main

        /// <summary>
        /// Helper function to start recursion with right secondary parameter
        /// </summary>
        /// <param name="n">THe number to test for being a prime number</param>
        /// <returns>True of False; true for a valid prime number</returns>
        static bool IsPrimeNumberHelperFast(int n)
        {
            return IsPrimeNumberFast(n, 2);
        }//IsPrimeNumberHelperFast()

        /// <summary>
        /// Helper function to start recursion with right secondary parameter
        /// </summary>
        /// <param name="n">THe number to test for being a prime number</param>
        /// <returns>True of False; true for a valid prime number</returns>
        static bool IsPrimeNumberHelperSlow(int n)
        {
            return IsPrimeNumberSlow(n, 2);
        }// IsPrimeNumberSlow()

        /// <summary>
        /// A faster algorithm for finding primes
        /// </summary>
        /// <param name="n">The number to be tested</param>
        /// <param name="divider">A helper parameter to determine the divider being tested</param>
        /// <returns>True if the given number is a prime</returns>
        static bool IsPrimeNumberFast(int n, int divider)
        {
            // stop condition 1: end of cycle?
            if (n <= 2) return (n == 2) ? false : true;

            // stop condition 2: division yields no fraction?
            // check if division yields no fraction ==> if so, this isn't a prime number
            if (n % divider == 0) return false;

            // stop condition 3: if the square of the divider is bigger than the given number it is a prime.
            // this is faster than another division (see slow function)
            if (divider * divider > n) return true;

            // handle the next divider and return result.
            // because there is no other operation after recursion the final conclusion will 'bubble up' to the caller
            return IsPrimeNumberFast(n, divider + 1);
        } //IsPrimeNumberFast()

        /// <summary>
        /// A fairly slow algorithm to find primes, due to expensive division function 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="divider"></param>
        /// <returns></returns>
        static bool IsPrimeNumberSlow(int n, int divider)
        {
            // stop condition 1: if N equals 1 it is a prime
            if (n == 1) return true;

            // stop condition 2: if N equals 2 it isn't a prime
            if (n == 2) return false;

            // stop condition 3: division yields no fraction?
            // check if division yields no fraction ==> if so, this isn't a prime number
            if (n % divider == 0) return false;

            // stop condition 4: if N divided by 2 is smaller than the given divider we can stop.
            // this is signficantly slower than the test for Squared dividers against N (see faster function)
            if (n / 2 < divider) return true;

            // handle the next divider and return result.
            // because there is no other operation after recursion the final conclusion will 'bubble up' to the caller
            return IsPrimeNumberSlow(n, divider + 1);
        }// IsPrimeNumberSlow()
    }//class
}// namespace