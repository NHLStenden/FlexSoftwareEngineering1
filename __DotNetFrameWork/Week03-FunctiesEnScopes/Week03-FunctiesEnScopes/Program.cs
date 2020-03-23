using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_FunctiesEnScopes
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 10;
            for (int i = 0; i < 10; i++)
            {

            }
            // onderstaande is niet toegestaan omdat de variabele i alleen in de 
            // scope van de for-lus bestaat
            //Console.WriteLine(i);

            int s = som(3, 4);
            int x = 3;
            int y = 4;

            int p = som(x, y);

            Console.WriteLine("X={0} / Y={1} / P={2}",x,y,p);

            SommeerGetallen(5);
        }
        // Onderstaande variabelen: 
        // * local scope van de functie
        // * call by VALUE
        static public int som(int x, int y)
        {
            x = x + 5;
            y = y + 6;
            return x + y;
        }//som()

        // call by value
        static public int SommeerGetallen(int getal)
        {
            if (getal == 0) return 0;
            return getal + SommeerGetallen(getal - 1);
        }

    }
}
