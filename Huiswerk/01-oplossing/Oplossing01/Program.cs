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
            Console.WriteLine("aba".Substring(1,0));


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
            String[] testWoorden = { "lepels", "lepel", "piet", "redder", "relder" };

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
            // bepaal de lengte van het woord.
            int len = woord.Length;

            // als het woord dat overgebleven is NUL of ÉÉN karakter bevat dan is het een palindroom (dit is een kwestie van definitie overigens)
            if (len <= 1) return true;

            // bepaal de eerste en laatste letter
            char left  = woord[0];
            char right = woord[len - 1];

            // als de eerste en de laatste letter gelijk zijn, zou het om een palindroom kunnen gaan.
            if (left == right)
            {
                // test of het inderdaad om een palindroom gaat door het restant opnieuw aan te bieden aan de functie.

                /**
                 * het restant wordt bepaald door de tweede tot en met de een-na-laatste letter op te halen
                 * en in een nieuwe string op te slaan.
                 * 
                 * zie URL https://docs.microsoft.com/en-us/dotnet/api/system.string.substring?view=netframework-4.8
                 * 
                 * LET OP: dit gaat goed doordat de functie SUBSTRING in ons geval altijd een woord krijgt 
                 * aangeboden van minimaal 2 karakters die ook allebei gelijk zijn (left == right). 
                 * 
                 * omdat 
                 *   len -2==0 
                 * levert de functie aanroep 
                 *      SUBSTRING ("AA", len -2)  ==> SUBSTRING ("AA", 0)
                 * een lege string op. De Stopconditie checkt of een lege string wordt teruggegeven en
                 * geeft dan TRUE als resultaat.
                 * 
                 * LET OP: deze aanroep vindt voor woord van twee karakters alleen plaats als ze gelijk zijn.
                 */

                String rest = woord.Substring(1, len - 2);

                // voer de functie opnieuw uit met het restant van het woord.
                return TestPalindroom(rest);
            }
            else
            {
                // letters zijn verschillend dus geen palindroom; return FALSE
                return false;
            }
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
            /* 
             * stopconditie: als n is NUL , dan resultaat toevoegen en stoppen. (immers de wortel van 0 = 0)
             */
            if (n == 0)
            {
                sqrts.Add(n);
                return;
            }
            // bereken de wortel
            double sqrt = Math.Sqrt(n);

            // kijk of de wortel een geheel getal is. zo ja, voeg toe aan de lijst

            // Methode A: typecast het resultaat naar een integer en vergelijk met de uitgerekende wortel. 
            //            als deze gelijk zijn is het een geheel getal
            bool isInteger1 = ((int)sqrt == sqrt);

            // Methode B: rond de uitegerekende wortel af, en trek de uitgerekende wortel daar van af. 
            //            als het verschil dat overblijft kleiner is een klein getal (epsilon = 0.000001) 
            //            dan gaat het zeer waarschijnlijk om een geheel getal.
            bool isInteger2 = Math.Abs (Math.Round(sqrt) - sqrt) < 0.000001;

            // Methode C: bereken de rest de deling 
            ///                wortel : 1 (wortel gedeeld door 1)
            ///           als het restant exact NUL is, is het een geheel getal.     
            bool isInteger3 = (sqrt % 1 == 0);
            if (isInteger1 && isInteger2 && isInteger3) sqrts.Add(n);

            // test de resterende getallen (1..n-1)
            FindAllIntegerSQRT(n - 1, sqrts);
        }//FindAllIntegerSQRT
    }
}

