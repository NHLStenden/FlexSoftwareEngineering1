using MyLinkedListClasses;
using NUnit.Framework;
using System;

namespace Lijsten
{
    class Program
    {
        static void Main(string[] args)
        {
            Stripboeken Collectie = new Stripboeken();

            int kosten = Collectie.BerekenKosten();
            Assert.AreEqual(0, kosten);

            Collectie.AddItem("Suske & Wiske en het eiland Amoris", 395);
            Collectie.AddItem("Suske & Wiske en de Zalige Ziener", 495);
            Collectie.AddItem("Suske & Wiske en de Scheve Schot ", 695);

            kosten = Collectie.BerekenKosten();
            Assert.AreEqual(1585, kosten);

            Collectie.AddItem("Suske & Wiske en de Jokkende Joker", 795);
            Collectie.AddItem("Suske & Wiske en de Game Goeroe", 1295);
            Collectie.AddItem("Suske & Wiske en de Knikkende Knoken", 295);

            kosten = Collectie.BerekenKosten();
            Assert.AreEqual(3970, kosten);

            Collectie.LeesBoeken();
            Collectie.LegBoekenTerugInDeKast();

            kosten = Collectie.BerekenKosten();

            Assert.AreEqual(3970, kosten);
            
            Collectie.clear();

            kosten = Collectie.BerekenKosten();

            Assert.AreEqual(0, kosten);


        }
    }
}
