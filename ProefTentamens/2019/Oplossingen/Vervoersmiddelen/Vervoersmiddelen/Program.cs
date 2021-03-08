using System;

namespace Vervoersmiddelen
{
    class Program
    {
        static void Main(string[] args)
        {
            BenzineAuto auto1 = new BenzineAuto("Maseratie"); 
            BenzineAuto auto2 = new BenzineAuto("BMW");
            
            DieselAuto auto3 = new DieselAuto("Citroen");
            DieselAuto auto4 = new DieselAuto("Fiat");
            
            Fiets fiets1 = new Fiets("Fiets van papa");
            Fiets fiets2 = new Fiets("Fiets van mama");
            
            ElectrischeFiets fiets3 = new ElectrischeFiets("Fiets van Opa");
            ElectrischeFiets fiets4 = new ElectrischeFiets("Fiets van Oma");
            
            Step step1 = new Step("step van zoon");
            Step step2 = new Step("step van dochter");
            
            Persoon Martin = new Persoon("Martin", "1234567");
            Persoon Roos = new Persoon("Roos", "1234567888");

            Martin.AddVervoersmiddel(auto1);
            Martin.AddVervoersmiddel(auto2);
            Martin.AddVervoersmiddel(step1);
            Martin.AddVervoersmiddel(fiets1);
            Martin.AddVervoersmiddel(fiets2);

            Roos.AddVervoersmiddel(auto3);
            Roos.AddVervoersmiddel(auto4);
            Roos.AddVervoersmiddel(fiets3);
            Roos.AddVervoersmiddel(fiets4);
            Martin.AddVervoersmiddel(step2);

            
            Martin.Report();
            Roos.Report();
            
        }
    }
}