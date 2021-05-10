using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading
{
    class SpecialNumber
    {
        private int getal;

        public SpecialNumber(int getal)
        {
            this.getal = getal;
        }

        public int Getal { get => getal; set => getal = value; }

        public static SpecialNumber operator +(SpecialNumber a, SpecialNumber b)
        {
            int result = a.Getal + b.Getal;

            SpecialNumber objResult = new SpecialNumber(result);

            return objResult;
        }

        public static SpecialNumber operator *(SpecialNumber a, SpecialNumber b)
        {
            return new SpecialNumber(a.Getal * b.Getal);
        }

            
    }
}
