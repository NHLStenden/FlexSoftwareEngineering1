using System;

namespace Objecten03
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage FastNLoud = new Garage();
            Garage ChasingClassicCars = new Garage();
            Garage KindigCustoms = new Garage();

            Auto Ferrari458 = new Auto("Ferrari",    "458 Italia",      Aandrijving.Benzine);
            Auto Eleanor    = new Auto("Ford",       "Mustang 500 GTE", Aandrijving.Benzine);
            Auto Delorean   = new Auto("DMC",        "Delorean 12",     Aandrijving.Benzine);
            Auto Herbi      = new Auto("Volkswagen", "Beetle",          Aandrijving.Diesel);
            Auto Tesla      = new Auto("Tesla",      "Model X",         Aandrijving.Electrisch);

            FastNLoud.AddCar(Herbi);
            FastNLoud.AddCar(Ferrari458);

            ChasingClassicCars.AddCar(Eleanor);
            ChasingClassicCars.AddCar(Delorean);

            KindigCustoms.AddCar(Tesla);

            Console.WriteLine("Kindig heeft {0} autos", KindigCustoms.Count);
            KindigCustoms.Report();
                        
            Console.WriteLine("ChasingClassicCars heeft {0} autos", ChasingClassicCars.Count);
            ChasingClassicCars.Report();

            Console.WriteLine("FastNLoud heeft {0} autos", FastNLoud.Count);
            FastNLoud.Report();

        }
    }
}
