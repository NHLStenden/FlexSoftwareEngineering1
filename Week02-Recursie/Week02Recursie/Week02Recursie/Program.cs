using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02Recursie
{
    class Program
    {
        static void Main(string[] args)
        {
            // zolang er een getal ingevoerd wordt, zet dit in een lijst
            // als er geen getal (lege invoer) is gegeven, tel deze lijst met getallen op
            // zet het totaal met 2 decimalen en € teken op de uitvoer
            List<float> lijstMetGetallen = new List<float>();

            bool doorgaan = true;
            while (doorgaan)
            {
                string strGetal = Console.ReadLine().Trim();
                doorgaan = (strGetal.Length != 0);
                if (doorgaan)
                {
                    // zet iets in de lijst; converteer van string naar getal
                    float getal =  System.Convert.ToSingle(strGetal);

                    Console.WriteLine("Ontvangen: {0}", getal);

                    lijstMetGetallen.Add(getal);

                    Console.WriteLine("Items in de lijst : {0}", lijstMetGetallen.Count);

                }
            }//while


            //klassieke methode
            for (int i = 0; i < lijstMetGetallen.Count; i++)
            {
                var item = lijstMetGetallen[i];
                Console.WriteLine(item);
            }

            Console.WriteLine("Totaal = € {0}", OptellenLijst(lijstMetGetallen));

            String woord = "Hallo";

            Console.WriteLine("{0} omgedraaid = {1}", woord, omdraaien(woord));

            Console.ReadLine();
        }
        /// <summary>
        ///   Deze mooie functie die telt alle floats in de lijst op en geeft het totaal terug!
        /// </summary>
        /// <param name="getallen">Een lijst gevuld met getallen van het type float</param>
        /// <returns>Het totaal van de getallen in de lijst</returns>
        static public float OptellenLijst(List<float> getallen)
        {
            float totaal = 0;
            foreach (var item in getallen)
            {
                totaal += item;
            }

            return totaal;
        }//OptellenLijst

        static public float OptellenLijstRecursief(List<float> lijst)
        {
            if (lijst.Count == 0) return 0;

            List<float> nieuweLijst = new List<float>(lijst);
            nieuweLijst.RemoveAt(0);

            /**

            float deelresultaat;
            deelresultaat = lijst[0];
            deelresultaat += OptellenLijstRecursief(nieuweLijst);
            return deelresultaat;
    */
            return lijst[0] + OptellenLijstRecursief(nieuweLijst);

        }//OptellenLijstRecursief

        static public String omdraaien(String tekst)
        {
            if (tekst.Length <= 1) return tekst;

            /*
            char eerste = tekst[0];

            string staart = tekst.Substring(1);

            string deelresultaat = omdraaien(staart);

            return deelresultaat + eerste;*/

            return omdraaien(tekst.Substring(1)) + tekst[0];
        }//omdraaien
    }
}
