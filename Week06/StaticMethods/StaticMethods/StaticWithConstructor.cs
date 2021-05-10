using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors"/>
    static class StaticWithConstructor
    {
        static string name;
        static StaticWithConstructor()
        {
            name = "Martin Molema";

            // this.name werkt hier niet: THIS refereert aan geheugen van een OBJECT, en een static class is geen OBJECT!
            //
            // mocht je wel in de knoei komen gebruik dan de class-name om de compiler te helpen ("Disambiguation"). 
            StaticWithConstructor.name = "Martin Molema";
        }

        static public void PrintNaam()
        {
            Console.WriteLine(name); 
            Console.WriteLine(StaticWithConstructor.name); 
        }
    }
}
