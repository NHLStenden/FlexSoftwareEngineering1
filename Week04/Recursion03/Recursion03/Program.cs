using System;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace Recursion03
{
    class Program
    {
        static void Main(string[] args)
        {
            //DrawPyramid(5,0);
            DrawPyramidHelper(14);
        }

        // dit zou ook een overloaded functie kunnen zijn. 
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
                Console.WriteLine("{0}**", new String(' ', level * 1));
                return;
            }
            ;
            
            // maak een string om in te springen
            string indent = new String(' ', level * 1);
            string bricks = new String('+', number * 2);

            // teken eerst de onderliggende lagen
            DrawPyramid(number - 1, level +1);

            // teken nu de huidige laag
            Console.WriteLine("{0} {1}", indent, bricks);

            // er is officieel geen return value
            return; 
        }

    }
}