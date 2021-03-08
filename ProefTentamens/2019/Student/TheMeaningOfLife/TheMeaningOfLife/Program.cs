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
            }
        }
        static int OneOr42(int getal)
        {
            throw new NotImplementedException();
        }

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
        }

    }
}