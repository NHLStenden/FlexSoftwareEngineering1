using System;

namespace Vervoersmiddelen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Vervoersmiddel v1 = new Vervoersmiddel(6, "Zwart");
            Fiets f1 = new Fiets("Rood");
            Fiets f2 = new Fiets("Rood");
            Fiets f3 = new Fiets("Rood");

            Console.WriteLine(f1.watIsHetAantalWielen());
            Console.WriteLine(f2.watIsHetAantalWielen());
            Console.WriteLine(f3.watIsHetAantalWielen());
            Console.WriteLine(v1.watIsHetAantalWielen());
        }
    }
}
