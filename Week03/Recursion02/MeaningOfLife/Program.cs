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
            // schrijf een functie OneOr42Counter die het aantal stappen teruggeeft dat nodig is om bij 1 of 42 uit te komen. 
            // de huidige functie OneOr42 moet dan op een klein aantal stappen worden aangepast.
            // dus 999 => 42 in 7 stappen (of 8 als je 42 in de stopconditie ook meetelt als stap).
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
        static int OneOr42Counter(int getal)
        {
            return 1;
        }

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
