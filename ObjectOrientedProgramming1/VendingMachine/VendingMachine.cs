using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class VendingMachine
    {
        private string Kleur;
        private string Stroomaansluiting;
        /// <summary>De hoeveel ingeworpen geld in EURO cent</summary>
        private int Ingeworpengeld;

        /// <summary>
        /// Deze constructor maakt een vendingmachine van een bepaalde kleur 
        /// met een opgegeven stekker voor de stroomaansluiting
        /// </summary>
        /// <param name="kleur">Dit mag een gewone tekstuele kleur zijn. bijvoorbeeld "rood"</param>
        /// <param name="stroomaansluiting">KEuze uit "230V" of "110V" of "380V"</param>
        public VendingMachine(string kleur, string stroomaansluiting)
        {
            Kleur = kleur;
            Stroomaansluiting = stroomaansluiting;
            Ingeworpengeld = 0;
        }

        /// <summary>
        /// "GETTER" voor de private variable "Kleur"
        /// </summary>
        /// <returns>de kleur die bij de constructor opgegeven is</returns>
        public string kleur()
        {
            return this.Kleur;
        }

        /// <summary>
        /// Deze functie zorgt voor het verhogen van het saldo door geld in te werpen
        /// Mits het om muntjes gaat van de valuta in EURO.
        /// </summary>
        /// <param name="inworp">Valuta aanduiding + inworp in centen. 
        /// bijvoorbeeld "EURO 10" is 10 eurocent</param>
        /// <returns>0 als ongeldige waarde. anders het geaccepteerde aantal 
        /// eurocent dat aan het saldo is toegevoegd</returns>
        public int Geldinwerpen(string inworp)
        {
            string[] parts = inworp.Split(' ');
            int money = 0;

            if ( parts[0] == "EURO")
            {
                try
                {
                    money = int.Parse(parts[1]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               
                this.Ingeworpengeld += money;
            }
            return money;
        }// Geldinwerpen()

        public string SaldoWeergave()
        {
            return "";
        }// SaldoWeergave()

        public int Saldo()
        {
            return this.Ingeworpengeld;
        }//IngeworpenGeld()


    }//class VendingMachine
}
