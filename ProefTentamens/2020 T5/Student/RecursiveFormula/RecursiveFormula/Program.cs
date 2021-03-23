using NUnit.Framework;
using System;

namespace RecursiveFormula
{
    class Program
    {
        static void Main(string[] args)
        {

        }// Main

        /// <summary>
        /// Berekent het aantal oneven getallen 
        /// </summary>
        /// <param name="number">Input is getal van 1 t/m 100 (inclusief)</param>
        /// <returns>het aantal oneven getallen bij deling door 2</returns>
        static public int CalcSteps(int number)
        {
            // stop conditie: als we bij het getal 1 zijn: stop dan en geef het resultaat 1 terug (zie opdracht)
            if (number == 1 )
            {
                return 1;
            }
            bool isOneven = (number % 2) == 1; // modulo-operator % => wat is de rest van deling tussen number en 2. 

            // wat is de huidige situatie
            int huidigeSituatie = number;

            // wat is het huidige resultaat?
            int resultaat = 0;
            if (isOneven)
            {
                resultaat = 1;
            }
            else
            {
                resultaat = 0;
            }

            // bepaal het restant
            int restant = 0;

            if (isOneven)
            {
                restant = (number + 1) / 2;
            }
            else
            {
                restant = number / 2;
            }

            // roep recursief aan en onthoudt het resultaat
            int resultaatVanDeRest = CalcSteps(restant);

            // wat is het eindresultaat van dit niveau?
            int eindResultaat = resultaat + resultaatVanDeRest;

            // return resultaat

            return eindResultaat;

        }// CalcSteps

        static int CalcStepsKort(int number)
        {
            if (number == 1) return 1;
            if (number % 2 == 0 ) // even
            {
                return 0 + CalcStepsKort(number / 2);
            }
            else // oneven
            {
                return 1 + CalcStepsKort((number + 1) / 2);            
            }
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 1)]
        [TestCase(5, 3)]
        [TestCase(6, 2)]
        [TestCase(7, 2)]
        [TestCase(8, 1)]
        [TestCase(9, 4)]
        [TestCase(10, 3)]
        [TestCase(11, 3)]
        [TestCase(12, 2)]
        [TestCase(13, 3)]
        [TestCase(14, 2)]
        [TestCase(15, 2)]
        [TestCase(16, 1)]
        [TestCase(17, 5)]
        [TestCase(18, 4)]
        [TestCase(19, 4)]
        [TestCase(20, 3)]
        [TestCase(21, 4)]
        [TestCase(22, 3)]
        [TestCase(23, 3)]
        [TestCase(24, 2)]
        [TestCase(25, 4)]
        [TestCase(26, 3)]
        [TestCase(27, 3)]
        [TestCase(28, 2)]
        [TestCase(29, 3)]
        [TestCase(30, 2)]
        [TestCase(31, 2)]
        [TestCase(32, 1)]
        [TestCase(33, 6)]
        [TestCase(34, 5)]
        [TestCase(35, 5)]
        [TestCase(36, 4)]
        [TestCase(37, 5)]
        [TestCase(38, 4)]
        [TestCase(39, 4)]
        [TestCase(40, 3)]
        [TestCase(41, 5)]
        [TestCase(42, 4)]
        [TestCase(43, 4)]
        [TestCase(44, 3)]
        [TestCase(45, 4)]
        [TestCase(46, 3)]
        [TestCase(47, 3)]
        [TestCase(48, 2)]
        [TestCase(49, 5)]
        [TestCase(50, 4)]
        [TestCase(51, 4)]
        [TestCase(52, 3)]
        [TestCase(53, 4)]
        [TestCase(54, 3)]
        [TestCase(55, 3)]
        [TestCase(56, 2)]
        [TestCase(57, 4)]
        [TestCase(58, 3)]
        [TestCase(59, 3)]
        [TestCase(60, 2)]
        [TestCase(61, 3)]
        [TestCase(62, 2)]
        [TestCase(63, 2)]
        [TestCase(64, 1)]
        [TestCase(65, 7)]
        [TestCase(66, 6)]
        [TestCase(67, 6)]
        [TestCase(68, 5)]
        [TestCase(69, 6)]
        [TestCase(70, 5)]
        [TestCase(71, 5)]
        [TestCase(72, 4)]
        [TestCase(73, 6)]
        [TestCase(74, 5)]
        [TestCase(75, 5)]
        [TestCase(76, 4)]
        [TestCase(77, 5)]
        [TestCase(78, 4)]
        [TestCase(79, 4)]
        [TestCase(80, 3)]
        [TestCase(81, 6)]
        [TestCase(82, 5)]
        [TestCase(83, 5)]
        [TestCase(84, 4)]
        [TestCase(85, 5)]
        [TestCase(86, 4)]
        [TestCase(87, 4)]
        [TestCase(88, 3)]
        [TestCase(89, 5)]
        [TestCase(90, 4)]
        [TestCase(91, 4)]
        [TestCase(92, 3)]
        [TestCase(93, 4)]
        [TestCase(94, 3)]
        [TestCase(95, 3)]
        [TestCase(96, 2)]
        [TestCase(97, 6)]
        [TestCase(98, 5)]
        [TestCase(99, 5)]
        static public void TestCalculations(int input, int output)
        {
            Assert.AreEqual(output, CalcStepsKort(input));
        }
    }



}
