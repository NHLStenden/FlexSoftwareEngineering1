using NUnit.Framework;
using System;

namespace Testing00
{
    class Program
    {
        static void Main(string[] args)
        {
            // wanneer gebruik je een for-lus?
            // dus : je weet hoe vaak je er doorheen wilt gaan
            // nul of meer keer

            int i = 0;

            Console.WriteLine(i);   // output = 0
            Console.WriteLine(i++); // output = 0
            Console.WriteLine(++i); // output = 2

            for (i = 0; i < 10 ; i++)
            {

            }

            // sowieso 1x er door heen omdat de conditie aan het einde staat
            // exit controlled
            do { } while(false);

            // oneindig? 
            // je weet eigenlijk nog niet hoe vaak (van tevoren)
            // nul tot oneindig
            // entry controlled
            
            while (false) { }

            int[] arr = { 1,2,3,4 };

            // loop door alle items in de array, volgorde is voor mij niet belangrijk; ik weet niet waar ik ben in de array (positie)
            foreach (var item in arr)
            {
                Console.Write("{0}," , item);
            }
            Console.WriteLine();

            // loop door alle items, ik weet waar ik ben (positie)
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write("{0}", arr[j]);
                if (j< arr.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();

            Console.WriteLine(DitIsFalse());
            Console.WriteLine(DitIsTrue());

            Console.WriteLine("Testcase A");
            if (DitIsFalse() && DitIsTrue()) // and :: beide moeten waar zijn
            {
                // als waar
                Console.WriteLine("Deze combinatie is waar");
            }

            Console.WriteLine("Testcase B");
            if (DitIsTrue() || DitIsFalse()) // or ::
            {
                // als waar
                Console.WriteLine("Deze combinatie is waar");
            }

            Console.WriteLine("Testcase C");
            if (! false) // not ::  tegenovergesteld NOT(true) == false
            {
                // als waar
                Console.WriteLine("Deze combinatie is waar");
            }

            Console.WriteLine("Testcase D");
            if (true ^ false) // xor :: precies één van beide beweringen is waar
            {
                // als waar
                Console.WriteLine("Deze combinatie is waar");
            }


        }

        private static bool DitIsFalse()
        {
            Console.WriteLine("Dit is false");
            return false;
        }

        private static bool DitIsTrue()
        {
            Console.WriteLine("Dit is true");
            return true;
        }


        [Test]
        public static void TestNaam()
        {
            string Naam = "Martin";
            Assert.AreEqual("martin", Naam);
        }


        [Test]
        public static void TestMe()
        {
            Assert.AreEqual(true, true);
        }
        [Test]
        public static void TestMe2()
        {
            Assert.AreNotEqual(true, false);
        }
        [Test]
        public static void TestMe3()
        {
            Assert.IsFalse(false);
        }
        [Test]
        public static void TestMe4()
        {
            Assert.Negative(-1);
        }
    }
}
