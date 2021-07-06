using System;
using Vormen;

namespace TentamenFlexHerkansing
{
    class Program
    {
        static void Main(string[] args)
        {
            Tekening t = new Tekening();
            Kubus k1 = new Kubus(1, 1, "blauw", 4,5,6);
            Kubus k2 = new Kubus(4, 2, "rood", 1,2,3);
            Kubus k3 = new Kubus(6, 3, "geel", 3,3,3);
            Kubus k4 = new Kubus(8, 4, "oranje", 9,9,9);

            t.Add(k1).Add(k2).Add(k3).Add(k4);

            Vierkant v1 = new Vierkant(10, 10, "rood", 5);
            Vierkant v2 = new Vierkant(20, 11, "geel", 6);
            Vierkant v3 = new Vierkant(30, 12, "blauw", 7);
            Vierkant v4 = new Vierkant(40, 13, "paars", 8);

            t.Add(v1).Add(v2).Add(v3).Add(v4);

            Cirkel c1 = new Cirkel(81, 19, "blauw", 5);
            Cirkel c2 = new Cirkel(82, 19, "groen", 6);
            Cirkel c3 = new Cirkel(83, 91, "oranje", 7);

            t.Add(c1).Add(c2).Add(c3);

            t.Paint();

        }
    }
}
