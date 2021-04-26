using System;

namespace MeaningOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("{0} = {1}", i, OneOr42(i));
                Console.WriteLine("{0} = {1} stappen", i, OneOr42Counter(i));
            }

            int n = 100000;
            Console.WriteLine("Tussen 0 en {0} zitten {1} oneven getallen", n, OnevenGetallenTellen(n) );
            Console.WriteLine("Tussen 0 en {0} zitten {1} oneven getallen", n, OnevenGetallenTellenShort(n) );

        }

        static int OneOr42(int getal)
        {
            if (getal == 42 || getal == 1)
            {
                return getal; // todo
            }
            int huidigElement = getal;

            int huidigeResultaat = Calculate(huidigElement); // 99 => 243

            int restant = huidigeResultaat;

            int resultaatRestant = OneOr42(restant);

            return resultaatRestant;

        }

        // schrijf een functie OneOr42Counter die het aantal stappen teruggeeft dat nodig is om bij 1 of 42 uit te komen. 
        // de huidige functie OneOr42 moet dan op een klein aantal stappen worden aangepast.
        // dus 999 => 42 in 7 stappen (of 8 als je 42 in de stopconditie ook meetelt als stap).

        static int OneOr42Counter(int getal)
        {
            if (getal == 42 || getal == 1)
            {
                return 1; // is dit nu nul of één? telt 1 of 42 ook als een stap; want je hebt in wezen de eindsituatie bereikt. dus zou NUL kunnen zijn. 
            }
            int huidigElement = getal;

            int huidigeResultaat = Calculate(huidigElement); 

            int restant = huidigeResultaat;

            int resultaatRestant = OneOr42Counter(restant);

            return 1 + resultaatRestant;
        }

        static int OnevenGetallenTellen(int getal)
        {
            if (getal <= 0)
            {
                return 0; // want 0 is een even getal, en we moeten oneven getallen tellen.
            }

            int huidigeElement = getal;

            int huidigResultaat = (getal % 2) == 1 ? 1 : 0; // dus als het getal oneven is tellen we er 1 bij op; anders nul.

            int restant = getal - 1;

            int resultaatRestant = OnevenGetallenTellen(restant);

            return huidigResultaat + resultaatRestant;
        }// OnevenGetallenTellen

        static int OnevenGetallenTellenShort(int getal)
        {
            if (getal <= 0)
            {
                return 0; // want 0 is een even getal, en we moeten oneven getallen tellen.
            }
            return ((getal % 2) == 1 ? 1 : 0) + OnevenGetallenTellenShort(getal - 1); // let op: haakjes nodig om voorrang af te dwingen. 
        }// OnevenGetallenTellenShort



        static int Calculate(int getal)
        {
            // converteer naar een string: 123 => "123"
            string txt = getal.ToString();

            // tussenresultaat 
            int result = 0;

            // loop alle cijfers in het getal af; dit levert een char op in de variabele C
            foreach (char c in txt) // '1' (char) => 1 (int)
            {
                // bereken de waarde van één van de cijfers in het getal. in deze lus
                // is C een CHAR. de integer waarde van C is dan 49 voor het cijfer 0, 50 voor cijfer 1
                // daarom trekken we de integer waarde van char '0' er af.
                int val = c - '0'; // ''0'= ascii 48

                // of gebruik parseInt. maak dan eerst van van de CHAR weer een string door deze 
                // achter een lege string toe voegen. 
                // int val = int.Parse("" + c);
                result += val * val;
            }
            return result;

        }

    }
}
