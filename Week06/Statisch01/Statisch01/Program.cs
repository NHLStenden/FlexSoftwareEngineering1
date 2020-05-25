using System;
using Microsoft.VisualBasic;

namespace Statisch01
{
    class Program
    {
        private static int getal;
        
        static void Main(string[] args)
        {
            Counter c1 = new Counter();
            int currentValue = c1.Add();
            Console.WriteLine(currentValue);
            currentValue = c1.Add();
            Console.WriteLine(currentValue);
            currentValue = c1.Add();
            Console.WriteLine(currentValue);
            currentValue = c1.Add();
            Console.WriteLine(currentValue);

            c1.Multiply(2)
                .Multiply(3)
                .Multiply(4); // chaining
            
            Console.WriteLine(c1.count);
            
            currentValue = c1.Multiply(2).Add();  // chaining. de methode .Add() geeft de laatste waarde terug die je kunt opvangen. 
            Console.WriteLine(currentValue);

            Console.WriteLine("----------------------");

            Counter2 c2 = new Counter2();
            Counter2 c3 = new Counter2();
            Counter2 c4 = new Counter2();
            Counter2 c5 = new Counter2();
            Counter2 c6 = new Counter2();

            Console.WriteLine(Counter2.Count);
            Console.WriteLine(Counter2.Random());

            NietStatic();

            getal = 10;
            Console.WriteLine(getal);
        }


        public static void NietStatic()
        {
            Console.WriteLine("fout");
        }
    }
}
