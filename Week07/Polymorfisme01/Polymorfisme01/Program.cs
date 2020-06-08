using System;
using System.Collections.Generic;
using System.Linq;

namespace Polymorfisme01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Computer c1 = new Computer();
            Laptop lap1 = new Laptop();
            Desktop desk1 = new Desktop();
            RaspberryPi pi1 = new RaspberryPi();
            RaspberryPi pi2 = new RaspberryPi();
            RaspberryPi pi3 = new RaspberryPi();
            RaspberryPi pi4 = new RaspberryPi();
            RaspberryPi pi5 = new RaspberryPi();

            List<Computer> myComputers = new List<Computer>();

            myComputers.Add(c1);
            myComputers.Add(lap1);
            myComputers.Add(pi1);
            myComputers.Add(pi2);
            myComputers.Add(pi3);
            myComputers.Add(pi4);
            myComputers.Add(pi5);
            myComputers.Add(desk1);

            // gebruik polymorfisme om de lijst af te lopen. op compiletijd kan dit grotendeels gecontroleerd worden
            // pas op runtime wordt precies duidelijk wat het type is van elk van de elementen uit de lijst met computers
            // en wordt de juiste methode aangeroepen (de 'opstarten'-methode van de bijbehorende klasse)
            foreach (Computer computer in myComputers)
            {
                ComputerOpstarten(computer);
            }

            // *******************************************************************************************************
            // **** LET OP : DIT HOEF JE NIET VOOR HET TENTAMEN TE WETEN! ALLEEN NUTTIG VOOR DE NIEUWSGIERIGEN *******
            // *******************************************************************************************************
            // calculate total computing power
            int power = 0;
            foreach (Computer computer in myComputers)
            {
                power = power + computer; // use the overloading function to add an int to a Computer
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Totale rekenkracht = {0}", power);

            // Nogmaals overloading gebruiken maar dan op een andere manier
            Console.WriteLine("---------------------------------------------");
            power = pi1 + pi2 + pi3 + pi4 + pi5;
            // eigenlijk gebeurt er zoiets als dit: pi1+pi2 ==> integer + pi3 ==> integer +pi4 ==> resultaat
            Console.WriteLine("Totale rekenkracht Raspberry Pis = {0}", power);

            // onderstaande een bijzonder voorbeeld A+B is niet altijd gelijk aan B+A
            // daarom worden hier dus twee verschillende overload-functies voor gebruikt.
            Console.WriteLine(pi1 + 1);
            Console.WriteLine(1 + pi1);

            // een ander voorbeeld: zoek alle items in de lijst 'myComputers' van het type 'RasbperryPi' en 
            // en voer een aggregeer-functie uit die de COmputingpower optelt. De 'Aggregate' functie maakt gebruik van de
            // overloaded '+' functie (int+Computer levert een int). 
            // https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.oftype?redirectedfrom=MSDN&view=netcore-3.1#System_Linq_Enumerable_OfType__1_System_Collections_IEnumerable_
            // https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.aggregate?view=netcore-3.1
            power = myComputers.OfType<RaspberryPi>().Aggregate(0, (current, next) => current + next);

            Console.WriteLine("Totale rekenkracht Raspberry Pis = {0}", power);

            // *******************************************************************************************************
            // *******************************************************************************************************
            // *******************************************************************************************************
        } // main

        static void ComputerOpstarten(Computer computer)
        {
            Type t = computer.GetType();
            bool isDitEenLaptop = t.Equals(typeof(Laptop));

            if (isDitEenLaptop)
            {
                Console.WriteLine("Hoera! Een laptop");
                Laptop laptop = computer as Laptop;
                laptop.DoeKlepOpen();
                laptop.Opstarten();
            }
            else
            {
                computer.Opstarten();
            }
        }
    }
}