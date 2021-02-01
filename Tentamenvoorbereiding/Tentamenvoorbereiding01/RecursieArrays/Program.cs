using System;

namespace RecursieArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lijstje = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 11,12,13,14,15,16,17,18,19,20 };  // ARRAY (net als string) zijn 'immutable'. ==> je kunt de lengte / aantal elementen in de array niet veranderen. 
            Console.WriteLine(sommeer(lijstje));
            Console.WriteLine(sommeerIndexed(lijstje));
            Console.WriteLine(sommeerVanAchteren(lijstje));
        }

        static int sommeer(int[] getallen)
        {
            if (getallen.Length == 0)
            {
                return 0;
            }
            int huidigeElement = getallen[0];

            int huidigeResultaat = huidigeElement;

            int[] rest = new int[getallen.Length - 1]; // maak ruimte voor de nieuwe array minus 1 positie, want die hebben we al gehad!
            // https://stackoverflow.com/questions/733243/how-to-copy-part-of-an-array-to-another-array-in-c
            Array.Copy(getallen, 1, rest, 0, rest.Length);

            int resultaatVanDeRest = sommeer(rest);

            return huidigeResultaat + resultaatVanDeRest;
        }
        static int sommeerVanAchteren(int[] getallen)
        {
            if (getallen.Length == 0)
            {
                return 0;
            }
            int huidigeElement = getallen[getallen.Length - 1];  // pak het laatste element

            int huidigeResultaat = huidigeElement;

            int[] rest = new int[getallen.Length - 1]; // maak ruimte voor de nieuwe array minus 1 positie, want die hebben we al gehad!
            // https://stackoverflow.com/questions/733243/how-to-copy-part-of-an-array-to-another-array-in-c
            Array.Copy(getallen, 0, rest, 0, rest.Length);

            int resultaatVanDeRest = sommeer(rest);

            return huidigeResultaat + resultaatVanDeRest;
        }


        // dit is een hulpfunctie om te voorkomen dat de aanroepende partij het getal NUL zelf mee moet geven. 
        static int sommeerIndexed(int[] getallen)
        {
            return sommeerIndexedRecursie(getallen, 0);
        }

        static int sommeerIndexedRecursie(int[] getallen, int index)
        {
            if (index == getallen.Length)
            {
                return 0;
            }
            return getallen[index] + sommeerIndexedRecursie(getallen, index + 1);
        }        
        
        static int sommeerKwadraatIndexedRecursie(int[] getallen, int index)
        {
            // stopconditie : als ik 10 getallen heb, dan is de maximale index = 9 getallen[0] is geldig, getallen[9] is geldig; getallen[10] mag je niet opvragen. je begint bij 0.
            // dus de index loopt van 0..1..2..3..4..5..6..7..8..9
            if (index == getallen.Length)
            {
                return 0;
            }
            return (getallen[index] * getallen[index]) + sommeerKwadraatIndexedRecursie(getallen, index + 1);
        }


    }
}
