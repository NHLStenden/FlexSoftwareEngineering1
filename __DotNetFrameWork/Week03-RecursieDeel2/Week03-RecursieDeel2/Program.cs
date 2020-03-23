using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Week03_RecursieDeel2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SommeerGetallen(35));
            /*
            List<int> lijst = new List<int>();
            lijst.AddRange(Enumerable.Range(1, 10000));
            lijst.Add(4);
            lijst.Add(5);
            lijst.Add(6);
            lijst.Add(7);

            Console.WriteLine(lijst.Count);

            Console.WriteLine(OptellenLijstRecursief2(lijst));

            */

            Console.ReadLine();
        }

        /// <summary>
        /// Sommeert de getallen van 1..getal en geeft dit terug als resultaat
        /// </summary>
        /// <param name="getal">Het getal tot welke waarde gesommeerd moet worden</param>
        /// <returns></returns>
        static public int SommeerGetallen(int getal)
        {
            /* "normale variant"
            int result = getal;
            for (int i = 1; i < getal; i++)
            {
                result += i;
            }

            return result;
            */

            if (getal == 0) return 0;
            /*
            int huidigeWaarde = getal;
            int resterendeWaarde = getal - 1;

            int resultaat = huidigeWaarde + SommeerGetallen(resterendeWaarde);

            return resultaat;*/

            return getal + SommeerGetallen(getal - 1);
        }
        /// <summary>
        /// Test de sommeer functie. (gebruikt NUnit.Framework)
        /// </summary>
        [Test]
        static public void TestSommeer()
        {
            Assert.AreEqual(SommeerGetallen(5), 15);
            Assert.AreEqual(SommeerGetallen(6), 21);
            Assert.AreEqual(SommeerGetallen(7), 28);
            Assert.AreEqual(SommeerGetallen(8), 36);
            Assert.AreEqual(SommeerGetallen(9), 45);
            Assert.AreEqual(SommeerGetallen(10), 55);
            Assert.AreEqual(SommeerGetallen(11), 66);
            Assert.AreEqual(SommeerGetallen(12), 78);

        }

        static public int OptellenLijstRecursief(List<int> lijst)
        {
            return OptellenLijstRecursiefExecute(lijst, lijst.Count - 1);
        }

        static private int OptellenLijstRecursiefExecute(List<int> lijst, int startpositie)
        {
            if (startpositie == 0) return lijst[0];

            return lijst[startpositie] + OptellenLijstRecursiefExecute(lijst, startpositie - 1);

        }//OptellenLijstRecursief


        static public int OptellenLijstRecursief2(List<int> lijst)
        {
            if (lijst.Count == 0) return 0;

            List<int> nieuweLijst = new List<int>(lijst);
            nieuweLijst.RemoveAt(0);

            return lijst[0] + OptellenLijstRecursief2(nieuweLijst);

        }//OptellenLijstRecursief2


    }
}
