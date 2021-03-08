using System;
using NUnit.Framework;

namespace TheMeaningOfLife
{
    /**
 * Gebruikt de volgende Nuget packages:
 * - microsoft.net.test.dsk
 * - NUnit
 * - NUnit3TestAdapter
 */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("[TestCase({0},{1})]", i, OneOr42(i));
                Console.WriteLine("[TestCase({0},{1})]", i, OneOr42b(i));
            }
        }

        // Eerste variant waarbij het tussenresultaat opgeslagen wordt
        // handig voor debugging
        static int OneOr42(int getal)
        {
            // stop conditie ==> als 1 of 42 geef dan het resultaat terug

            if (getal == 1 || getal == 42) return getal;

            // behandel resultaat 
            int resultaat = Calculate(getal);

            return OneOr42(resultaat);
        }
        // Tweede verkorte variant die gebruik maakt van een andere rekenmethode
        static int OneOr42b(int getal)
        {
            if (getal == 1 || getal == 42) return getal;

            return OneOr42b(Calculate2(getal));
        }

        static int Calculate2(int getal)
        {
            // wiskundige variant van dezelfde functie: we delen steeds door 10 totdat we op NUL komen

            int result = 0;

            // zolang getal niet nul is
            while (getal >0)
            {
                // bereken de rest (MODULO) van deling door 10
                int digit = getal % 10;
                
                // tel het kwadraat van één cijfer op
                result += digit * digit;

                // doe een INTEGER deling waardoor het getal steeds kleiner wordt. de rest wordt
                // weggegooid (13/10 = 1 en niet 13/10=1,3)
                getal = getal / 10;
            }

            return result;
        }

        static int Calculate(int getal)
        {
            // converteer naar een string
            string txt = getal.ToString();

            // tussenresultaat 
            int result = 0;

            // loop alle cijfers in het getal af; dit levert een char op in de variabele C
            foreach (char c in txt)
            {
                // bereken de waarde van één van de cijfers in het getal. in deze lus
                // is C een CHAR. de integer waarde van C is dan 49 voor het cijfer 0, 50 voor cijfer 1
                // daarom trekken we de integer waarde van char '0' er af.
                // int val = c - '0';

                // of gebruik parseInt. maak dan eerst van van de CHAR weer een string door deze 
                // achter een lege string toe voegen. 
                int val = int.Parse("" + c);
                result += val * val;
            }
            return result;

        }
        #region Testing

        [TestCase(1, 1)]
        [TestCase(2, 42)]
        [TestCase(3, 42)]
        [TestCase(4, 42)]
        [TestCase(5, 42)]
        [TestCase(6, 42)]
        [TestCase(7, 1)]
        [TestCase(8, 42)]
        [TestCase(9, 42)]
        [TestCase(10, 1)]
        [TestCase(11, 42)]
        [TestCase(12, 42)]
        [TestCase(13, 1)]
        [TestCase(14, 42)]
        [TestCase(15, 42)]
        [TestCase(16, 42)]
        [TestCase(17, 42)]
        [TestCase(18, 42)]
        [TestCase(19, 1)]
        [TestCase(20, 42)]
        [TestCase(21, 42)]
        [TestCase(22, 42)]
        [TestCase(23, 1)]
        [TestCase(24, 42)]
        [TestCase(25, 42)]
        [TestCase(26, 42)]
        [TestCase(27, 42)]
        [TestCase(28, 1)]
        [TestCase(29, 42)]
        [TestCase(30, 42)]
        [TestCase(31, 1)]
        [TestCase(32, 1)]
        [TestCase(33, 42)]
        [TestCase(34, 42)]
        [TestCase(35, 42)]
        [TestCase(36, 42)]
        [TestCase(37, 42)]
        [TestCase(38, 42)]
        [TestCase(39, 42)]
        [TestCase(40, 42)]
        [TestCase(41, 42)]
        [TestCase(42, 42)]
        [TestCase(43, 42)]
        [TestCase(44, 1)]
        [TestCase(45, 42)]
        [TestCase(46, 42)]
        [TestCase(47, 42)]
        [TestCase(48, 42)]
        [TestCase(49, 1)]
        [TestCase(50, 42)]
        [TestCase(51, 42)]
        [TestCase(52, 42)]
        [TestCase(53, 42)]
        [TestCase(54, 42)]
        [TestCase(55, 42)]
        [TestCase(56, 42)]
        [TestCase(57, 42)]
        [TestCase(58, 42)]
        [TestCase(59, 42)]
        [TestCase(60, 42)]
        [TestCase(61, 42)]
        [TestCase(62, 42)]
        [TestCase(63, 42)]
        [TestCase(64, 42)]
        [TestCase(65, 42)]
        [TestCase(66, 42)]
        [TestCase(67, 42)]
        [TestCase(68, 1)]
        [TestCase(69, 42)]
        [TestCase(70, 1)]
        [TestCase(71, 42)]
        [TestCase(72, 42)]
        [TestCase(73, 42)]
        [TestCase(74, 42)]
        [TestCase(75, 42)]
        [TestCase(76, 42)]
        [TestCase(77, 42)]
        [TestCase(78, 42)]
        [TestCase(79, 1)]
        [TestCase(80, 42)]
        [TestCase(81, 42)]
        [TestCase(82, 1)]
        [TestCase(83, 42)]
        [TestCase(84, 42)]
        [TestCase(85, 42)]
        [TestCase(86, 1)]
        [TestCase(87, 42)]
        [TestCase(88, 42)]
        [TestCase(89, 42)]
        [TestCase(90, 42)]
        [TestCase(91, 1)]
        [TestCase(92, 42)]
        [TestCase(93, 42)]
        [TestCase(94, 1)]
        [TestCase(95, 42)]
        [TestCase(96, 42)]
        [TestCase(97, 1)]
        [TestCase(98, 42)]
        [TestCase(99, 42)]
        static public void Tests1(int input, int output)
        {
            Assert.AreEqual(output, OneOr42(input));
            Assert.AreEqual(output, OneOr42b(input));
        }
        #endregion

    }
}