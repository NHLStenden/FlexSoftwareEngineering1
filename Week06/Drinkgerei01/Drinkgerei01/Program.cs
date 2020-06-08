using System;
using System.Runtime.CompilerServices;
using Drinkgerei01.classes;

namespace Drinkgerei01
{
    class Program
    {
        static void Main(string[] args)
        {
            Amsterdammertje A1 = new Amsterdammertje(20);
            Glas G1 = new Glas(true, "Thee", 30, 30, 250, true, 0, 4);


            Console.WriteLine("{0} {1} {2} {3}", A1.Hoeveelheid, A1.Capaciteit, A1.HeeftOor, A1.SoortDrank);
        }
    }
}