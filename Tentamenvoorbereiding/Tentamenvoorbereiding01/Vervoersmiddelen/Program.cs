using System;
using System.Collections.Generic;

namespace Vervoersmiddelen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Vervoersmiddel v1 = new Vervoersmiddel(6, "Zwart");
            Fiets f1 = new Fiets("Rood");
            Fiets f2 = new Fiets("Wit");
            Fiets f3 = new Fiets("Blauw");

            Console.WriteLine(f1.watIsHetAantalWielen());
            Console.WriteLine(f2.watIsHetAantalWielen());
            Console.WriteLine(f3.watIsHetAantalWielen());
            Console.WriteLine(v1.watIsHetAantalWielen());


            Auto audi = new Auto(AantalDeurenEnum.drie, "Zwart");
            Auto porsche = new DieselAuto("Blauw");
            Console.WriteLine("Aantal deuren van de audi = {0}", audi.AantalDeuren());

            List<Vervoersmiddel> mijnVervoersmiddelen = new List<Vervoersmiddel>();

            mijnVervoersmiddelen.Add(f1);
            mijnVervoersmiddelen.Add(f2);
            mijnVervoersmiddelen.Add(f3);
            mijnVervoersmiddelen.Add(audi);
            mijnVervoersmiddelen.Add(v1);
            mijnVervoersmiddelen.Add(porsche);

            foreach (Vervoersmiddel verv in mijnVervoersmiddelen)
            {
                verv.SnelheidPlus(10);
            }

/*
 * DIT MAG DUS NIET want een INT is geen object dat POLYMORFISME volgt.
 *          List<int> getallen = new List<int>();
            getallen.Add(3);
            getallen.Add(4);
            getallen.Add(5);
            getallen.Add(5.2);
            getallen.Add("een tekst");
*/        }
    }
}
