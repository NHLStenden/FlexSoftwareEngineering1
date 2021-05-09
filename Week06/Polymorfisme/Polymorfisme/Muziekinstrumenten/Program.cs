﻿using System;
using System.Collections.Generic;

namespace Muziekinstrumenten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Piano p1 = new Piano("Martin's Yamaha U1");
            Piano p2 = new Piano("Martin's Yamaha P105b");
            Dwarsfluit f1 = new Dwarsfluit("Berdien Stenberg's device");
            
            p1.MaakGeluid();
            p2.MaakGeluid();
            f1.MaakGeluid();

            List<Muziekinstrument> collectie = new List<Muziekinstrument>();
            collectie.Add(p1);
            collectie.Add(p2);
            collectie.Add(f1);

            // Polymorfisme: laat dotnet zelf uitzoeken als het programma loopt ("Runtime") welke klasse nu 
            // precies behandeld wordt in de for-loop. Dit in tegenstelling tot Compile-time.
            foreach (Muziekinstrument muziekinstrument in collectie)
            {
                muziekinstrument.MaakGeluid();
            }
            
            foreach (Muziekinstrument muziekinstrument in collectie)
            {
                muziekinstrument.MaakGeluid();
                if (muziekinstrument is Dwarsfluit)
                {
                    (muziekinstrument as Dwarsfluit).Poetsen();
                    Dwarsfluit dwarsfluit = muziekinstrument as Dwarsfluit;
                    dwarsfluit.Poetsen();
                    
                }
            }
            
            
            
            
        }
    }
}