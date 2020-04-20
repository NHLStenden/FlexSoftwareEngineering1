using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;

namespace Lists01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type-aanduiding => List<string>
            // variabelenaam => namen
            // = voor initialisatie
            // initialisatie statement of waarde
            
            List<string> namen = new List<string>();
            List<int>    getallen = new List<int>(10);

            getallen.Add(5); // achteraan toevoegen.
            getallen.Add(4); // achteraan toevoegen.
            getallen.Add(3); // achteraan toevoegen.
            getallen.Add(2); // achteraan toevoegen.
            getallen.Add(1); // achteraan toevoegen.
            getallen[2] = 10;
            
            for(int k=0;k<40;k++) getallen.Add(k * k);

            IEnumerable<int> filter =
                from getal in getallen
                where getal < 100
                select getal;

            foreach (var getal in filter)
            {
                Console.WriteLine(getal);
            }
            
            //foreach (var getal in getallen) Console.WriteLine(getal);
            //int[] reeks = new int[10];
            
            namen.Add("Martin");
            namen.Add("Jos");
            namen.Add("Karel");
            namen.Add("Koen");

            // omdat de List-klasse iterable is kunnen we een for-each 
            // statement gebruiken.
            int i = 0;
            foreach (var name in namen)
            {
                Console.Write("{0} = {1}", i,name);
                if (i< namen.Count -1) Console.Write(",");
                i++;
            }

            Console.WriteLine();
            for (int j = 0; j < namen.Count; j++)
            {
                Console.Write("{0} = {1}", j, namen[j]);
                if (j< namen.Count -1) Console.Write(",");
            }
            
            Dictionary<string, int> leeftijden =new Dictionary<string, int>(10);
            leeftijden.Add("Martin", 49);
            leeftijden.Add("Leo", 21);
            leeftijden.Add("Tinus", 13);
            leeftijden.Add("Alfred", 75);


            foreach (var item in leeftijden)
            {
                Console.WriteLine("{0} heeft leeftijd {1}",item.Key, item.Value);
            }

            Console.WriteLine(leeftijden["Martin"]);
                
            Dictionary<string, string> achternamen = new Dictionary<string, string>(10);
            achternamen["Martin"] = "Molema";
            achternamen["Koen"] = "de Vries";
            achternamen["Mark"] = "Rutte";
            achternamen["Herman"] = "van Veen";
            foreach (var achternaam in achternamen)
            {
                Console.WriteLine(achternaam.Value);
            }

            Console.ReadLine();
        }
    }
}