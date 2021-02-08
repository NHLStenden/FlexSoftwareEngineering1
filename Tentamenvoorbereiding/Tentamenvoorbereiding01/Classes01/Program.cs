using System;

namespace Classes01
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello frisdrankautomaat");

            FrisdrankAutomaat automaat1 = new FrisdrankAutomaat("Rengerslaan 8");
            Console.WriteLine(automaat1.watIsHetSaldo());

            int huidigSaldo;
            huidigSaldo = automaat1.watIsHetSaldo();

            if (huidigSaldo == 0)
            {
                huidigSaldo = automaat1.verhoogSaldo(2);
            }
            Console.WriteLine(huidigSaldo);

            // dit mag dus niet: Console.WriteLine(automaat1.saldo);
        }
    }
}
