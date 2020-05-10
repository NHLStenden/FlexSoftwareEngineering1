using System;
using NUnit.Framework;

namespace Recursion02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Optellen(10));
            Console.WriteLine(Vermenigvuldigen(10));
            Console.WriteLine(ReverseString("Martin"));
            
        }

        /// <summary>
        /// Test de functie Optellen() met een aantal vaste tests
        /// </summary>
        [Test]
        public static void TestOptellen()
        {
            Assert.AreEqual(0, Optellen(0));
            Assert.AreEqual(0, Optellen(-1)); // let op: gebruik dus in je recursie <= 0 anders stopt de procedure niet bij negatieve getallen
            Assert.AreEqual(1, Optellen(1));
            Assert.AreEqual(3, Optellen(2));
            Assert.AreEqual(6, Optellen(3));
            Assert.AreEqual(55, Optellen(10));
        }

        /// <summary>
        /// Test de Optellen() functie met verschillende combinaties van input en output
        /// </summary>
        /// <param name="input">De input parameter</param>
        /// <param name="result">Het verwachtte resultaat</param>
        [TestCase(0, 0)]
        [TestCase(-1, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 3)]
        [TestCase(3, 6)]
        [TestCase(4, 10)]
        [TestCase(5, 15)]
        [TestCase(10, 55)]
        public static void TestOptellen2(int input, int result)
        {
            Assert.AreEqual(result,Optellen(input));
        }

        /// <summary>
        /// Test de vermenigvuldigingsfunctie met een lus.
        /// </summary>
        [Test]
        public static void TestVermenigvuldigen()
        {
            int result = 1;
            for (int i = 1; i <= 10; i++)
            {
                result *= i;
                Assert.AreEqual(result, Vermenigvuldigen(i));
            }
            
        }

        [TestCase("Martin", "nitraM")]
        public static void TestStringReverse(string input, string output)
        {
            Assert.AreEqual(output, ReverseString(input));
        }

        /// <summary>
        /// Take the cumulative sum of all value between 0..getal
        /// </summary>
        /// <param name="number">Any integer value greater or equal to zero</param>
        /// <returns>sum(0...getal)</returns>
        static int Optellen(int number)
        {
            //stopconditie ==> als we nul hebben bereikt, dan stoppen. 
            // belangrijk bij de stop-conditie ==> Welke waarde geef je terug om op de juiste manier het resultaat
            // wel of niet te beinvloeden?
            // omdat we optellen, geef je het getal 0 terug: x + 0 = x
            if (number <= 0) return 0;

            // bepaal resultaat van de huidige situatie 
            int result = number;
            
            // behandel de rest van de gegevens
            result += Optellen(number - 1);

            // tijdelijk resultaat teruggeven ==> de laatste keer is dit het juiste resultaat
            return result;
        }

        /// <summary>
        /// Vermenigvuldig de getallen van 1 t/m getal (beter bekend als de Faculteit berekening)
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int Vermenigvuldigen(int number)
        {
            // let op: de stop conditie stopt in dit geval al bij 1 ipv nul
            // immers: we vermenigvuldigen! Als we bij 0 stoppen en 0 teruggeven is het antwoord ook nul! (x keer 0 = 0)
            if (number <= 1) return 1;
            
            // bepaal huidige situatie
            int result = number;
            
            // behandel de rest
            result *= Vermenigvuldigen(number - 1);

            // tijdelijk resultaat teruggeven ==> de laatste keer is dit het juiste resultaat
            return result;
        }

        /// <summary>
        /// Reverses a given string
        /// </summary>
        /// <param name="text">The string to be reversed</param>
        /// <returns>A reversed string</returns>
        static string ReverseString(string text)
        {
            // stopconditie: lege string? dan stoppen; 
            if (text.Length == 0) return "";
            
            // huidige situatie ==> verwerking uitstellen omdat we willen omdraaien
            char c = text[0];
            
            // behandel de rest
            string result = ReverseString(text.Substring(1));
            
            // bepaal het lokale resultaat door het resultaat van de 'staart' te verbinden met de huidige situatie
            // Door de huidige situatie achter het resultaat van de 'staart' te plaatsen ontstaat een omgedraaide tekst
            result = String.Concat(result, c);

            return result;
        }
    }
}