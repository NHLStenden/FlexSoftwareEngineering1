using System;

namespace Recursion02
{
    class Program
    {
        static void Main(string[] args)
        {
            string woord1 = "MARTIN";
            Console.WriteLine(klein(woord1));
            Console.WriteLine(kleinAchterstevoren(woord1));
            Console.WriteLine(kleinAchterstevorenLong(woord1));
        }

        static string klein(string woord)
        {
            if (woord.Length == 0)
            {
                return ""; // want "MARTIN" + "" == "MARTIN"
            }
            return woord.Substring(0, 1).ToLower() + klein(woord.Substring(1));
        }
        static string kleinAchterstevoren(string woord)
        {
            if (woord.Length == 0)
            {
                return ""; // want "MARTIN" + "" == "MARTIN"
            }
            return kleinAchterstevoren(woord.Substring(1)) + woord.Substring(0, 1).ToLower();
        }

        static string kleinAchterstevorenLong(string woord)
        {
            if (woord.Length == 0)
            {
                return ""; // want "MARTIN" + "" == "MARTIN"
            }
            string huidigeElement = woord.Substring(0, 1);
            string huidigeResulaat = huidigeElement.ToLower();

            string restant = woord.Substring(1);
            string resultaatVanHetRestant = kleinAchterstevorenLong(restant);

            string resultaat = resultaatVanHetRestant + huidigeResulaat;

            return resultaat;

        }
    }
}
