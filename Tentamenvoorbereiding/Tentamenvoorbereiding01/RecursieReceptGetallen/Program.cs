using System;

namespace RecursieReceptGetallen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sommeer(4));  // sommeer 4 == 10 == 1+2+3+4
            Console.WriteLine(sommeerKort(5));  // sommeer 4 == 10 == 1+2+3+4
            Console.WriteLine(sommeerKwadraten(4));  // sommeer 4 == 1*1 + 2*2 + 3*3 + 4*4 = 1 + 4 + 9 + 16 == 30
            Console.WriteLine(sommeerKwadraatKort(4));  // sommeer 4 == 1*1 + 2*2 + 3*3 + 4*4 = 1 + 4 + 9 + 16 == 30
        }

        static public int sommeer(int getal)
        {
            // stop conditie? 
            if (getal == 0)
            {
                return 0;// stap 2
            }

            int huidigeElement = getal; // stap 3

            // stap 4: wat moet ik er mee doen? 
            int huidigeResultaat = huidigeElement; // stap 4

            // stap 5
            int restant = huidigeElement - 1;

            // step 6 + 7 
            int resultaatVanDeRest = sommeer(restant);

            // stap 8
            int combinatieResultaat = resultaatVanDeRest + huidigeResultaat;

            // stap 9
            return combinatieResultaat;

        }

        static public int sommeerKwadraten(int getal)
        {
            // stop conditie? 
            if (getal == 0)
            {
                return 0;// stap 2
            }

            int huidigeElement = getal; // stap 3

            // stap 4: wat moet ik er mee doen?  ==> kwadrateer het huidige element (x => x*x)
            int huidigeResultaat = huidigeElement * huidigeElement; // stap 4

            // stap 5
            int restant = huidigeElement - 1;

            // step 6 + 7 
            int resultaatVanDeRest = sommeerKwadraten(restant);

            // stap 8
            int combinatieResultaat = resultaatVanDeRest + huidigeResultaat;

            // stap 9
            return combinatieResultaat;
        }



        static public int sommeerKort(int getal)
        {
            if (getal == 0 )
            {
                return 0;
            }
            return getal + sommeerKort(getal - 1);
        }


        static public int sommeerKwadraatKort(int getal)
        {
            if (getal == 0 )
            {
                return 0;
            }
            return (getal * getal) + sommeerKwadraatKort(getal - 1);
        }


    }
}
