using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    class HalfStaticClass
    {
        private string naam;

        /// <summary>
        /// Normale constructor (niet static) met één parameter. Er wordt een private variabele ingesteld.
        /// </summary>
        /// <param name="naam">De naam van iets</param>
        public HalfStaticClass(string naam)
        {
            this.naam = naam;
        }

        static public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }

        public void PrintNaam()
        {
            Console.WriteLine(naam);
        }
    }
}
