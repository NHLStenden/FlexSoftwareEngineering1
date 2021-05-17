using System;

namespace StaticMethods
{
    /// <summary>
    /// Voorbeelden met gebruik van Static sleutelwoord
    /// </summary>

    class Program
    {
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // "Normale manier": eerst een nieuw object maken ("instantieëren") op basis van de klasse "NormalClass"
            NormalClass n1 = new NormalClass("Martin");
            n1.PrintNaam();
            
            // volgende stap: gebruik maken van een STATIC method in een andere klasse ('StaticClass');
            // verschil: we maken niet eerst een nieuw object aan (met NEW), maar gebruiken de naam van de klasse.
            int resultaat = StaticClass.AddTwoNumbers(1, 2);
            Console.WriteLine(resultaat);

            // als je deze wel probeert te instantiëren krijg je een foutmelding
            // Bijvoorbeeld:
            // StaticClass x = new StaticClass();
            // fout: Cannot declare a variable of static type 'StaticClass’
            // fout: Cannot create an instance of the static class 'StaticClass'

            // nu een mengvorm
            HalfStaticClass h1 = new HalfStaticClass("Molema");
            h1.PrintNaam();

            int resultaat2 = HalfStaticClass.AddTwoNumbers(4, 5);
            Console.WriteLine(resultaat2);


            // nu gebruiken we een mengvorm waarbij we kunnen tellen hoe vaak de klasse is omgezet naar een Object met NEW
            ClassCounter c1 = new ClassCounter();
            ClassCounter c2 = new ClassCounter();
            ClassCounter c3 = new ClassCounter();
            Console.WriteLine("Er zijn nu {0} instanties van klasse ClassCounter", ClassCounter.Counter());

            ClassCounter c4 = new ClassCounter();
            ClassCounter c5 = new ClassCounter();
            ClassCounter c6 = new ClassCounter();
            ClassCounter c7 = new ClassCounter();

            Console.WriteLine("Er zijn nu {0} instanties van klasse ClassCounter", ClassCounter.Counter());

        }
    }
}
