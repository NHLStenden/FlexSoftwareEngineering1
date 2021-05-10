using System;

namespace OperatorOverloading
{
    /// <summary>
    /// 
    /// 
    /// </summary>
    /// <seealso cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading"/>
    class Program
    {
        static void Main(string[] args)
        {
            SpecialNumber x1 = new SpecialNumber(10);
            SpecialNumber x2 = new SpecialNumber(3);

            SpecialNumber r1 = x1 + x2;
            SpecialNumber r2 = x1 * x2;

            Console.WriteLine("Resultaat 1 : {0}", r1.Getal);
            Console.WriteLine("Resultaat 2 : {0}", r2.Getal);

            SpecialList list = new SpecialList();

            Console.WriteLine(list[1]);
            Console.WriteLine(list[3]);
            Console.WriteLine(list[5]);

            // dit is eigenlijk ook operator overloading.
            string x = "AA" + "BB";

        }
    }
}
