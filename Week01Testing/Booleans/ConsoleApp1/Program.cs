using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (GeefFalseTerug() && GeefTrueTerug()) // Conditional AND (CAND) = && ; evaluatie van links naar rechts!
            {
                Console.WriteLine("Hoera CAND");
            }
            Console.WriteLine("----------------------");
            if (GeefTrueTerug() || GeefFalseTerug())
            {
                Console.WriteLine("Hoera COR");
            }
            Console.WriteLine("----------------------");
            if (GeefTrueTerug() ^ GeefFalseTerug())
            {
                Console.WriteLine("Hoera XOR1");
            }            
            Console.WriteLine("----------------------");
            if (GeefFalseTerug() ^ GeefTrueTerug())
            {
                Console.WriteLine("Hoera XOR2");
            }

            Console.WriteLine("----------------------");
            if (GeefTrueTerug() | GeefFalseTerug())
            {
                Console.WriteLine("Hoera Normal OR");
            }

            Console.WriteLine("----------------------");

            int input = 13;
            int mask = 18;

            Console.WriteLine("{0} = {1}",input, Convert.ToString(input, 2));
            Console.WriteLine("{0} = {1}",mask,  Convert.ToString(mask, 2));
            Console.WriteLine("----------------------");
            Console.WriteLine(input | mask );
            Console.WriteLine(input & mask );

            string martin = "Molema";
            foreach (char item in martin)
            {
                Console.WriteLine("{0} = {1} {2}", item, (int)item, Convert.ToString(item, 2));
            }

        }// Main

        static bool GeefFalseTerug()
        {
            Console.WriteLine("GeefFalseTerug");
            return false;
        } 
        static bool GeefTrueTerug()
        {
            Console.WriteLine("GeefTrueTerug");
            return true;
        } 
    }
}
