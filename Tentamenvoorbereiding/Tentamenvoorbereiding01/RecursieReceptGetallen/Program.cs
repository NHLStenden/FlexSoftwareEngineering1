using System;

namespace RecursieReceptGetallen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sommeer(4));  // sommeer 4 == 10 == 1+2+3+4
        }

        static public int sommeer(int getal)
        {
            // stop conditie? 
            if (getal == 0)
            {
                return 0;// stap 2
            }

            int huidigeElement = ; // stap 3

            // stap 4: wat moet ik er mee doen? 
            int huidigeResultaat = ; // stap 4

            // stap 5
            int restant = ;

            // step 6 + 7 
            int resultaatVanDeRest = sommeer(restant);

            // stap 8
            int combinatieResultaat = ;

            // stap 9
            return combinatieResultaat;

        }
    }
}
