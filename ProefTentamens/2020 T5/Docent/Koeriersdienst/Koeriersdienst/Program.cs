using System;

namespace Koeriersdienst
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentLinkedListString lijst = new StudentLinkedListString();

            lijst.AddItem("Strijkijzer");
            lijst.AddItem("Ghettoblaster");
            lijst.AddItem("RaspberryPi");
            lijst.AddItem("Smartphone Galaxy S10");
            lijst.AddItem("Shampoo");
            lijst.AddItem("WC Papier");

            Console.WriteLine("Pakketten");
            Console.WriteLine("----------------------------");
            int aantal = lijst.PakketjesLijst();

            Console.WriteLine("----------------------------");
            Console.WriteLine("{0} Pakketten", aantal);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Routelijst");
            lijst.RouteLijst();
        }
    }
}
