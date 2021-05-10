using System;

namespace FunctionOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 5;
            int i2 = 6;
            int i3 = 7;

            int ir1 = SmartFunctions.Add(i1, i2);
            int ir2 = SmartFunctions.Add(i1, i2, i3);

            Console.WriteLine("Resultaten A {0} / {1}",  ir1, ir2);

            double d1 = 10;
            double d2 = 4;

            double dr1 = SmartFunctions.Add(d1, d2);
            double dr2 = SmartFunctions.Add(d1, i1);

            Console.WriteLine("Resultaten B {0} / {1}", dr1, dr2);

            string sd1 = SmartFunctions.Add("EURO ", 10, 30);
            Console.WriteLine("Resultaten {0}", sd1);

            int[] ints = new int[] { 1, 2, 3, 4, 5, 6 };
            int ir3 = SmartFunctions.Sum(1, 2, 3, 4, 5, 6, 7 ,8 , 9, 10);  // geen array nodig; gewoon variabel aantal integers!
            int ir4 = SmartFunctions.Add(ints);
            double dr3 = SmartFunctions.Sum(1.1, 2.5, 3.6, 4.7);

            Console.WriteLine("Resultaten C {0} / {1}", ir3, ir4);
            Console.WriteLine("Resultaten D {0}", dr3);

            string sr3 = SmartFunctions.Add("EURO ", ",-", 1, 2, 3, 4, 5, 6, 7, 8, 9);
            Console.WriteLine("Resultaten E {0}", sr3);
        }
    }
}
