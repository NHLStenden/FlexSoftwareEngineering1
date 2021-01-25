using System;

namespace RecursieRecept
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(kleinAchterstevoren("Hello World!"));
        }

        static string klein(string woord)
        {
            // stop conditie (stap 1)
            if (woord == "")
            {
                // stap 2: geef een lege string terug zodat een lege string + bestaand resultaat (uit stap 8) = bestaatnd resultaat
                return "";
                // mag ook: return woord;
            }
            string huidigElement = woord.Substring(0, 1); // stap 3: de eerste letter van het woord

            // stap 4: hier zit dus de eigenlijk werking van deze functie
            string kleineLetterHuidigElement = huidigElement.ToLower();

            // stap 5: bepaal het restant
            string restant = woord.Substring(1); // let op: index voor substring begint in 0 (nul)

            // stap 7 (=vang het resultaat op) + 6 (= recursie aanroep)
            string resultaatVanDeRest = klein(restant);

            // stap 8: +operator = CONCAT = zet achter elkaar in de volgorde van de operands
            string combinatieResultaat = kleineLetterHuidigElement + resultaatVanDeRest;

            // stap 9
            return combinatieResultaat;
        }        
        
        static string kleinAchterstevoren(string woord)
        {
            // stop conditie (stap 1)
            if (woord == "")
            {
                // stap 2: geef een lege string terug zodat een lege string + bestaand resultaat (uit stap 8) = bestaatnd resultaat
                return "";
                // mag ook: return woord;
            }
            string huidigElement = woord.Substring(0, 1); // stap 3: de eerste letter van het woord

            // stap 4: hier zit dus de eigenlijk werking van deze functie
            string kleineLetterHuidigElement = huidigElement.ToLower();

            // stap 5: bepaal het restant
            string restant = woord.Substring(1); // let op: index voor substring begint in 0 (nul)

            // stap 7 (=vang het resultaat op) + 6 (= recursie aanroep)
            string resultaatVanDeRest = kleinAchterstevoren(restant);

            // stap 8: +operator = CONCAT = zet achter elkaar in de volgorde van de operands
            string combinatieResultaat = resultaatVanDeRest + kleineLetterHuidigElement;

            // stap 9
            return combinatieResultaat;
        }

        static public string kortEnKlein(string woord)
        {
            if (woord == "") return "";
            return woord.Substring(0, 1).ToLower() + kortEnKlein(woord.Substring(1));
        }
        static public string kortEnKleinAchterstevoren(string woord)
        {
            if (woord == "") return "";
            return kortEnKleinAchterstevoren(woord.Substring(1) + woord.Substring(0, 1).ToLower());
        }
    }
}
