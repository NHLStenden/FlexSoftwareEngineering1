using NUnit.Framework;
using System;

namespace Rekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertToInteger("1234"));
            Console.WriteLine(ConvertToInteger("2234"));
            Console.WriteLine(ConvertToInteger("1"));
            Console.WriteLine(ConvertToInteger("4321"));
            Console.WriteLine(ConvertToInteger("2323"));
            Console.WriteLine(ConvertToInteger("123"));
            Console.WriteLine(ConvertToInteger("0000"));
        }

        [TestCase("745", 745)]
        [TestCase("168", 168)]
        [TestCase("344", 344)]
        [TestCase("243", 243)]
        [TestCase("386", 386)]
        [TestCase("109", 109)]
        [TestCase("620", 620)]
        [TestCase("202", 202)]
        [TestCase("925", 925)]
        [TestCase("203", 203)]
        [TestCase("803", 803)]
        [TestCase("365", 365)]
        [TestCase("928", 928)]
        [TestCase("364", 364)]
        [TestCase("773", 773)]
        [TestCase("654", 654)]
        [TestCase("142", 142)]
        [TestCase("96", 96)]
        [TestCase("552", 552)]
        [TestCase("887", 887)]
        [TestCase("559", 559)]
        [TestCase("3", 3)]
        [TestCase("481", 481)]
        [TestCase("358", 358)]
        [TestCase("690", 690)]
        [TestCase("778", 778)]
        [TestCase("484", 484)]
        [TestCase("740", 740)]
        [TestCase("613", 613)]
        [TestCase("913", 913)]
        [TestCase("207", 207)]
        [TestCase("982", 982)]
        [TestCase("311", 311)]
        [TestCase("635", 635)]
        [TestCase("482", 482)]
        [TestCase("417", 417)]
        [TestCase("715", 715)]
        [TestCase("731", 731)]
        [TestCase("61", 61)]
        [TestCase("976", 976)]
        [TestCase("174", 174)]
        [TestCase("376", 376)]
        [TestCase("829", 829)]
        [TestCase("961", 961)]
        [TestCase("412", 412)]
        [TestCase("749", 749)]
        [TestCase("84", 84)]
        [TestCase("107", 107)]
        [TestCase("509", 509)]
        [TestCase("926", 926)]
        [TestCase("581", 581)]
        [TestCase("728", 728)]
        [TestCase("240", 240)]
        [TestCase("604", 604)]
        [TestCase("172", 172)]
        [TestCase("965", 965)]
        [TestCase("79", 79)]
        [TestCase("555", 555)]
        [TestCase("788", 788)]
        [TestCase("191", 191)]
        [TestCase("266", 266)]
        [TestCase("399", 399)]
        [TestCase("886", 886)]
        [TestCase("578", 578)]
        [TestCase("612", 612)]
        [TestCase("852", 852)]
        [TestCase("845", 845)]
        [TestCase("976", 976)]
        [TestCase("109", 109)]
        [TestCase("333", 333)]
        [TestCase("588", 588)]

        public static void TestConversion(string input, int result)
        {
            Assert.AreEqual(result, ConvertToInteger(input));
            Assert.AreEqual(input, ConvertToString(result));

        }


        /// <summary>
        /// Converteert een string naar de decimale waarde (integer). Werkt alleen voor positieve getallen.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>

        static public int ConvertToInteger(string number)
        {
            if (number == "")
            {
                return 0;
            }
            char c = number[number.Length-1];
            
            int value  = c - '0'; // convert to int
            
            string rest = number.Substring(0, number.Length - 1);

            return value + 10 * ConvertToInteger(rest);
        }

        static public string ConvertToString(int number)
        {
            if (number ==0 )
            {
                return "";
            }

            int digitInt = number % 10;

            char digitString = (char)('0' + digitInt);

            int newNumber = (number / 10);

            string result = ConvertToString(newNumber);

            return result + digitString;
        }
    }

}
