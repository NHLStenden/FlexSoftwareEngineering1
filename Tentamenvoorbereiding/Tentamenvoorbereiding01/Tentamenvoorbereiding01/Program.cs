using System;

namespace Tentamenvoorbereiding01
{
    class Program
    {
        static void Main(string[] args)
        {
            // nu een array van het type INTEGER, de [] geven aan dat je de lengte nog weet van de array, maar het initialisatie deel helpt de compiler.
            int[] items = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            // je weet precies hoe vaak je dit wilt uitvoeren (bijv. 10x)
            for (int i = 0; i < 10; i++) // de variabele i is alleen bekend binnen de accolades van de FOR-lus (scope = for lus)
            {
                Console.Write(items[i]);
                // als het niet de laatste is: druk een komma af
                if (i < 10 - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
            // Console.WriteLine(i); ==> dit mag dus niet!

            int j; // de variabele J is zichtbaar/bruikbaar in alle code die volgt binnen deze methode ('Main')
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("{0}:{1}", j, items[j]);
                // als het niet de laatste is: druk een komma af
            }
            Console.WriteLine("J is nu : {0}", j);

            // je weet niet hoe vaak, en het kan ook nul keer zijn (0 of meer)
            int k = 0;
            while (k < 10)
            {
                Console.Write(items[k]);
                if (k < 10 - 1)
                {
                    Console.Write(",");
                }
                k = k + 1; // k++
            }
            Console.WriteLine();

            // je weet niet hoe vaak, maar in ieder geval één keer (1 of meer).
            do
            {

            } while (false); // validatie of we moeten herhalen zit pas aan het einde.


            Console.WriteLine("Hier komt de FOR EACH output");
            // loop een lijst of array ('Iterable') waarbij je alle elementen behandeld, maar je weet er vrij weinig over:
            // is het de eerste, of laatste? 
            // conclusie: behandel alles op exact dezelfde manier
            int x = 0;
            foreach (var item in items)
            {
                Console.Write(item);
                if (x != items.Length - 1) // het is de laatste
                {
                    Console.Write(',');
                }
            }

            // -------------------------------------------------------------------------------------------------------------------------------------------

            // nu een array van het type INTEGER, de [] geven aan dat je de lengte nog weet van de array, maar het initialisatie deel helpt de compiler.
            int[] moreItems = { 1, 3, 2, 5, 3, 6, 4, 5, 7, 6, 53, 3, 5 };

            // je weet precies hoe vaak je dit wilt uitvoeren (bijv. 10x)
            for (int i = 0; i < moreItems.Length; i++) // de variabele i is alleen bekend binnen de accolades van de FOR-lus (scope = for lus)
            {
                Console.Write(moreItems[i]);
                // als het niet de laatste is: druk een komma af
                if (i < moreItems.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();

            // array met TWEE dimensies: rijen (= dimensie 0) en kolommen (=dimensie 1). We initialiseren dat met onderstaande structuur:
            int[,] temperaturen = {  // openen van de array initialisatie
              { 1,3,-3,5,6,16,10 },  // één rij
              { 10,5,3,5,6,15,10 }, // één rij 
              { 10,6,6,5,6,13,10 }, // één rij
              { 10,8,9,5,6,12,10 }, // één rij
              { 10,13,4,5,6,8,10 }, // één rij
            };// afsluiten van de array initialisatie

            // haal het aantal rijen en kolommen op van de array 'temperaturen'. 
            int cols = temperaturen.GetLength(1);
            int rows = temperaturen.GetLength(0);

            // stap 1 = Initialisatie (row = 0) dan check uitvoeren ( row < rows)
            // stap 2 .... n = Eerst Ophogen (row++) , daarna check uitvoeren;  ( row < rows)
            for (int row = 0; row < rows; row++) // temperaturen.GetLength(0) ==> hoeveel rijen zijn er?
            {
                // ergens moet je de binnenste lus dus goed beginnen: dus lus variabele initialiseren
                for (int col = 0; col < cols; col++) // temperaturen.GetLength(1) ==> hoeveel kolommen zijn er?
                {
                    Console.Write(temperaturen[row, col]);  // haal de inhoud van één cel op uit het geheugen (rij, kolom) en druk deze af. 
                    if (col < cols - 1)
                    {
                        Console.Write(",");
                    }
                }// for kolommen
                Console.WriteLine();
            }// for rijen

            int opgeteld;
            int[] getallen = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            opgeteld = optellen(getallen);
            Console.WriteLine(opgeteld);

        }// Main()

        //TODO: voor volgende week
        static int optellen(int[] lijstMetGetallen)
        {
            int result = 0;

            for (int i = 0; i < lijstMetGetallen.Length; i++)
            {
                result = result + lijstMetGetallen[i];
            }

            return result;
        }

        static string maakString()
        {
            return "Hello worlds";
        }
    }
}
