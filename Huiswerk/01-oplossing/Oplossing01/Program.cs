using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huiswerk01
{
    /// <summary>
    /// Oplossingen bij de huiswerkopdrachten 01
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /******************************************************************************************************************/
            // Zoek alle getallen waarvan de wortel een geheel getal is.
            /******************************************************************************************************************/

            // maak eerst een lijst waar de resultaten in opgeslagen kunnen worden
            List<int> sqrts = new List<int>();

            // roep de recursieve functie aan voor de getallen 0-100
            int n = 100;
            FindAllIntegerSQRT(n, sqrts);

            // om een mooie lijst te kunnen afdrukken sorteren we de resultaat lijst
            sqrts.Sort();

            // met een lijst kunnen we alles afdrukken met een FOREACH-lus
            Console.WriteLine("De volgende getallen hebben een wortel die een geheel getal is");
            foreach (int sqrt in sqrts) Console.WriteLine("- {0}", sqrt);

            // dat kan ook als volgt: dan roep je de methode 'forEach' op het object van de lijst. 
            // je moet dan een functie meegeven die op elk item uitgevoerd moet worden.
            Console.WriteLine("De volgende getallen hebben een wortel die een geheel getal is (alternatieve methode)");
            sqrts.ForEach(delegate (int wortel) {
                Console.WriteLine("- {0}", wortel);
            });


            /******************************************************************************************************************/
            // Zoek alle priemgetallen tot en met 100
            /******************************************************************************************************************/
            n = 100;

            // in dit geval geeft de functie een lijst terug. dit kan doordat we een hulpfunctie gebruiken die
            // de recursieve functie start 
            List<int> primes = FindPrimes(n);

            // druk het resultaat af. 
            Console.WriteLine("Lijst met priemgetallen tot en met {0}", n);
            foreach (int prime in primes) Console.WriteLine("- {0}" ,prime);

            /******************************************************************************************************************/
            // zoek een aantal woorden die omgekeerd hetzelfde woord vormen (Palindroom)
            /******************************************************************************************************************/

            Console.WriteLine("Zoeken naar palindromen");

            // definieer een Array waar de lijst met woorden in staat die we willen testen.
            String[] testWoorden = { "lepels", "lepel", "piet", "redder" };

            // doorloop alle elementen in de array en test of het een Palindroom is.
            n = testWoorden.Length;
            for (int i =0 ; i < n; i++)
            {
                string testWoord = testWoorden[i];
                bool isPalindroom = TestPalindroom(testWoord);

                // om een BOOLEAN af te drukken gebruiken we de conditional-operator (https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator) 
                Console.WriteLine("- {0} is {1} palindroom", testWoord, isPalindroom ? "een" : "geen");
            }

            // wacht met het sluiten van de Console door op een toets te wachten.
            Console.ReadKey();

        }

        /// <summary>
        /// Zoek alle priemgetallen tot en met het getal n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static List<int> FindPrimes(int n)
        {
            // maak eerst een lijst aan waar we de getallen in opslaan
            List<int> primes = new List<int>();

            // doorloop een lijst van 1..n en test voor elk getal of het een priemgetal is.
            // als het getal een priemgetal is, zet het dan in de lijst.
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
            // deze functie start de recursieve functie en geeft domweg het resultaat terug
            // er wordt een extra parameter meegegeven (n/2) die we 'factor' noemen.
            // lees 
            return RecursiveFindPrime(n, n / 2);
        }//IsPrime

        /// <summary>
        /// test of het getal (parameter n) een priemgetal is of niet. de gebruikte methode is dat er gezocht 
        /// wordt naar een deler (parameter factor) die een geheel getal oplevert. als zo'n deler gevonden wordt (en niet gelijk is aan 1)
        /// dan stopt de functie en geeft FALSE als resultaat.
        /// 
        /// Als de n/factor geen geheel getal oplevert, dan wordt gekeken of n/ (factor-1) een gehele deler heeft
        /// door de functie recursief opnieuw aan te roepen. 
        /// 
        /// </summary>
        /// <param name="n">het getal waarvoor getest wordt of het een priemgetal is</param>
        /// <param name="factor">dit getal moet de waarde n/2 krijgen bij de start van de functie.
        /// Het doel van deze parameter is dat we niet alle getallen tussen 1..n hoeven te gebruiken om de deling 
        /// uit te voeren. Immers 
        ///     10:5 = 2 
        ///en 
        ///     10:2 = 5
        ///    daarom volstaat het om alleen de factoren ("delers") te testen tussen 1..n/2. 
        /// </param>
        /// <returns></returns>
        static bool RecursiveFindPrime(int n, int factor)
        {
            // stopcondities: als factor is 1 of 0 stop dan (factor nul kan ontstaan bij deling van 1 door 2: integer deling 1/2 == 0)
            //
            if (factor == 1) return true;
            if (factor == 0) return true;

            // voer de deling uit door middel van een MODULO operator. als het restant van de deling NUL is
            // dan is de deling een geheel getal.

            int divisionResult = n % factor;

            // als een geheel getal, dan is het aangeboden getal (n) geen priemgetal 
            if (divisionResult == 0) return false;
            else
            {
                // het aangeboden getal (n) zou nog steeds een priemgetal kunnen zijn. dus testen we met het volgende
                // getal uit de reeks 'te delen door getallen' door de factor met 1 te verlagen.
                return RecursiveFindPrime(n, factor - 1);
            }
        }//RecursiveFindPrime


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
            if (woord.Length <= 1) return true;
            int len = woord.Length;
            char left = woord[0];
            char right = woord[len - 1];

            if (left == right)
            {
                String rest = woord.Substring(1, len - 2);
                return TestPalindroom(rest);
            }
            else return false;
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
            if (n == 0)
            {
                sqrts.Add(n);
                return;
            }
            double sqrt = Math.Sqrt(n);

            if ((int)sqrt == sqrt) sqrts.Add(n);

            FindAllIntegerSQRT(n - 1, sqrts);
        }//FindAllIntegerSQRT
    }
}

