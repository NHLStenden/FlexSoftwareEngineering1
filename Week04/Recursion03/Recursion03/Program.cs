using System;
using Microsoft.VisualBasic;

namespace Recursion03
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawPyramid(5,0);
            DrawPyramidHelper(5);
        }

        static void DrawPyramidHelper(int number)
        {
            DrawPyramid(number, 0);
        }

        static void DrawPyramid(int number, int level)
        {
            // stop conditie; geen return waarde (void-functie)
            if (number <= 0)
            {
                // draw a nice star on top.
                Console.WriteLine("{0}*", new String(' ', level * 2));
                return;
            }
            ;
            
            // maak een string om in te springen
            string indent = new String(' ', level * 2);
            string branches = new String('+', number*4);
            

            // teken eerst de onderliggende lagen
            DrawPyramid(number - 1, level +1);
            
            // teken nu de huidige laag
            Console.WriteLine("{0} {1}", indent, branches);

            // er is officieel geen return value
            return; 
        }
    }
}