using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huiswerk01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zoek alle getallen waarvan de wortel een geheel getal is.
            List<int> sqrts = new List<int>();
            FindAllIntegerSQRT(100, sqrts);
            sqrts.Sort();
            foreach (int sqrt in sqrts) Console.WriteLine(sqrt);

            // Zoek alle priemgetallen tot en met 15000
            List<int> primes = FindPrimes(15000);
            foreach (int prime in primes) Console.WriteLine(prime);

            // zoek een aantal woorden die omgekeerd hetzelfde woord vormen (Palindroom)
            String testWoord = "lepels";
            bool isPalindroom = TestPalindroom(testWoord);
            Console.WriteLine("{0} is {1} palindroom", testWoord, isPalindroom ? "een" : "geen");

            testWoord = "lepel";
            isPalindroom = TestPalindroom(testWoord);
            Console.WriteLine("{0} is {1} palindroom", testWoord, isPalindroom ? "een" : "geen");

            testWoord = "piet";
            isPalindroom = TestPalindroom(testWoord);
            Console.WriteLine("{0} is {1} palindroom", testWoord, isPalindroom ? "een" : "geen");

            Console.ReadKey();

        }

        /// <summary>
        /// Zoek alle priemgetallen tot en met het getal n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static List<int> FindPrimes(int n)
        {
            List<int> primes = new List<int>();
            foreach (int i in Enumerable.Range(1, n))
            {
                if (IsPrime(i)) primes.Add(i);
            }
            return primes;
        }//FindPrimes

        /// <summary>
        /// Bepaalt of een getal een priemgetal is. Gebruik de methode door recursief te kijken
        /// of het getal een deler heeft die een geheel getal oplevert (gebruik de MODULO operator: %)
        /// Als er geen deler is en je bereikt het getal 1, dan is het dus een priem getal.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool IsPrime(int n)
        {
            return false;
        }//IsPrime

        /// <summary>
        /// Test of een woord een palindroom is. Gebruik het mechanisme waarbij je kijkt 
        /// of de eerste en laatste letter gelijk zijn. zo ja, dan hak je de eerste en 
        /// laatste letter er  af, en ga je recursief kijken of dat voor het restant ook geldt.
        /// Let op dat je met even en oneven aantal letters moet kunnen werken.
        /// </summary>
        /// <param name="woord"></param>
        /// <returns>True als een woord een palindroom is</returns>
        static bool TestPalindroom(String woord)
        {
            return false;
        }//TestPalindroom

        /// <summary>
        /// Zoek alle integers tot n die een wortel hebben die een geheel getal vormen.
        /// Gebruik een recursieve functie die een item aan de lijst toevoegt.
        /// Gebruik voor het bepalen van de wortel de functie SQRT en om te kijken of een getal een geheel getal is
        /// kun je gebruik maken van de functie Floor (zie MSDN voor meer informatie): vergelijk de uitkomst met de 
        /// waarde van de wortel. als deze kleiner is dan een bepaalde afwijking (epsilon) dan is het inderdaad een integer
        /// </summary>
        /// <param name="n">Het maximale getal waarvan de wortel bepaald wordt</param>
        /// <param name="sqrts">Lijst met resultaten</param>
        static void FindAllIntegerSQRT(int n, List<int> sqrts)
        {
            double wortel = Math.Sqrt(n);
            bool isInteger = Math.Abs(Math.Floor(wortel) - wortel) < 0.00001;
            Console.WriteLine("Wortel {0} is {1} en is {2} een geheel getal", n, wortel, isInteger ? "wel" : "niet");
        }//FindAllIntegerSQRT
    }
}
