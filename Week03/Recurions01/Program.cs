using System;

namespace Recurions01
{

    class Persoon
    {
        public string naam;
        public Persoon vader, moeder;

        public Persoon(string naam)
        {
            this.naam = naam;
            vader = null;
            moeder = null;
        }

        public Persoon(string naam, Persoon vader, Persoon moeder)
        {
            this.naam = naam;
            this.vader = vader;
            this.moeder = moeder;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Persoon martin, vader, moeder, grootvader_v, grootmoeder_v, grootvader_m, grootmoeder_m;

            grootvader_m = new Persoon("Tinus");
            grootmoeder_m = new Persoon("Cornelia");

            grootvader_v = new Persoon("Jan");
            grootmoeder_v = new Persoon("Roos");

            vader = new Persoon("Hans", grootvader_v, grootmoeder_v);
            moeder = new Persoon("Grietje", grootvader_m, grootmoeder_m);

            martin = new Persoon("Martin", vader, moeder);

            PrintStamboom_Smart(martin, 0);
        }

        static void PrintStamboomVader(Persoon eenPersoon)
        {
            // Stopconditie
            if (eenPersoon == null) return;

            // behandel huidige situatie
            Console.WriteLine(eenPersoon.naam);

            // behandel resterende
            PrintStamboomVader(eenPersoon.vader);
        }

        static void PrintStamboomMoeder(Persoon eenPersoon)
        {
            // Stopconditie
            if (eenPersoon == null) return;

            // behandel huidige situatie
            Console.WriteLine(eenPersoon.naam);

            // behandel resterende
            PrintStamboomMoeder(eenPersoon.moeder);
        }

        static void PrintStamboomMoeder_leveled(Persoon eenPersoon, int level)
        {
            // Stopconditie
            if (eenPersoon == null) return;

            // behandel huidige situatie
            Console.WriteLine("{0} - {1}", new String(' ',level*2), eenPersoon.naam);

            // behandel resterende
            PrintStamboomMoeder_leveled(eenPersoon.moeder, level+1);
        }

        static void PrintStamboomVader_leveled(Persoon eenPersoon, int level)
        {
            // Stopconditie
            if (eenPersoon == null) return;

            // behandel huidige situatie
            Console.WriteLine("{0} - {1}", new String(' ',level*2), eenPersoon.naam);

            // behandel resterende
            PrintStamboomVader_leveled(eenPersoon.moeder, level+1);
        }
        static void PrintStamboomMoeder_Reverse_leveled(Persoon eenPersoon, int level)
        {
            // Stopconditie
            if (eenPersoon == null) return;


            // behandel resterende
            PrintStamboomMoeder_Reverse_leveled(eenPersoon.moeder, level+1);
            
            // behandel huidige situatie
            Console.WriteLine("{0} - {1}", new String(' ', level * 10), eenPersoon.naam);
        }

        static void PrintStamboomVader_Reverse_leveled(Persoon eenPersoon, int level)
        {
            // Stopconditie
            if (eenPersoon == null) return;

            // behandel resterende
            PrintStamboomVader_Reverse_leveled(eenPersoon.moeder, level+1);

            // behandel huidige situatie
            Console.WriteLine("{0} - {1}", new String(' ', level * 10), eenPersoon.naam);

        }

        static void PrintStamboom_Smart(Persoon eenPersoon, int level)
        {
            // Stopconditie
            if (eenPersoon == null)
            {
                return;
            }

            // behandel huidige situatie
            Console.Write("{0}", new String(' ', (level + 0) * 10));
            Console.WriteLine("{0}", eenPersoon.naam);

            // behandel resterende
            PrintStamboom_Smart(eenPersoon.moeder, level + 1);
            PrintStamboom_Smart(eenPersoon.vader, level + 1);

        }
    }


}
