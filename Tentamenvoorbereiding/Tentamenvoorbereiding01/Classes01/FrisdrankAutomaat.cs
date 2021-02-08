using System;
using System.Collections.Generic;
using System.Text;

namespace Classes01
{

    class FrisdrankAutomaat
    {
        private int saldo;
        private string locatie;

        /// <summary>
        /// COnstructor 
        /// </summary>
        public FrisdrankAutomaat(string locatie)
        {
            nieuwSaldo(0);
            this.locatie = locatie ;
        }// constructor

        public int verlaagSaldo(int delta)
        {
            if (watIsHetSaldo() - delta <0)
            {
                Console.WriteLine("Saldo wordt te laag!");
            }
            else
            {
                nieuwSaldo(watIsHetSaldo() - delta);
            }
            return watIsHetSaldo();
        }

        /// <summary>
        /// Verhoog het saldo met het aangegeven bedrag
        /// </summary>
        /// <param name="delta">Een positief getal om het saldo mee te verhogen</param>
        /// <returns>Het nieuwe saldo</returns>
        public int verhoogSaldo(int delta)
        {
            nieuwSaldo (watIsHetSaldo() + Math.Abs(delta));
            return saldo;
        }

        /// <summary>
        /// XMLDOC : https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/
        /// </summary>
        /// <returns></returns>
        public int watIsHetSaldo()
        {
            return saldo;
        }

        /// <summary>
        /// Sla het nieuwe saldo op. Wellicht moet het later wel naar een database oid en dan is het handig dat je dus niet zelf 
        /// die variabele 'saldo' rechtstreeks aanpast
        /// </summary>
        /// <param name="nieuw"></param>
        public void nieuwSaldo(int nieuw)
        {
            this.saldo = nieuw;
        }
    }
}
