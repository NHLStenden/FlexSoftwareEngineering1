using System;

namespace Polymorfisme01
{
    public class Computer
    {
        private int _processingPower;

        public int ProcessingPower
        {
            get => _processingPower;
            set => _processingPower = value;
        }

        public Computer()
        {
            this.ProcessingPower = 0;
        }

        public virtual  bool  Opstarten() 
        {
            Console.WriteLine("Computer:: Ok, ik ga opstarten");

            return true;
        }

        // overload 
        public virtual bool Opstarten(int tijd)
        {
            Console.WriteLine("Het opstarten kost even tijd..... ({0})", tijd);
            return true;
        }

        /// <summary>
        /// Deze procedure is static : je hoeft geen instantie te maken om deze functie aan te roepen.
        /// wel wordt deze optel procedure alleen mogelijk als het gaat om de optelling tussen twee computers.
        /// dus optellen van een Computer (of subclass) met een int is niet mogelijk.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static int operator+(Computer c1, Computer c2)
        {
            return c1.ProcessingPower + c2.ProcessingPower;
        }

        /// <summary>
        /// Om dit probleem van de vorige methode af te vangen moeten we een extra overload schrijven: eentje die wel
        /// een int en een computer kan optellen.
        /// </summary>
        /// <param name="startvalue"></param>
        /// <param name="c1"></param>
        /// <returns></returns>
        public static int operator +(int startvalue, Computer c1)
        {
            return startvalue + c1.ProcessingPower;
        }
        /// <summary>
        /// Omdat de PLUS-operator niet altijd hetzelfde is voor A+B en B+A moet je deze dubbel implementeren
        /// Immers als je twee strings 'bij elkaar optelt' ("MARTIN" + "MOLEMA") is de volgorde belangrijk
        /// "MARTIN" + "MOLEMA" is iets anders dan "MOLEMA" + "MARTIN" 
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="startvalue"></param>
        /// <returns></returns>
        public static int operator +(Computer c1, int startvalue)
        {
            return startvalue + c1; // use the existing overload function for convenience.
        }
        
        
    }
}