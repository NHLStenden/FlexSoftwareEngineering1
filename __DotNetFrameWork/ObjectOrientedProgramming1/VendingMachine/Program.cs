using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine machine1 = new VendingMachine("rood","230V");
            VendingMachine machine2 = new VendingMachine("blauw","230V");

            machine1.serialnumber = "122345";
            machine2.serialnumber = "987654321";

            Console.WriteLine("Serienummer van machine {1}: {0}",
                    machine1.serialnumber,
                    machine1.kleur());
			
			string input;
			do {
				input = Console.ReadLine();
				
				int money = machine1.Geldinwerpen(input);
				
				if (money != 0) Console.WriteLine("U heeft ingeworpen in machine {1}: {0}", 
                    machine1.SaldoWeergave(), 
                    machine1.kleur());
                Console.WriteLine("Saldo machine {1} : {0}", 
                    machine2.SaldoWeergave(), 
                    machine2.kleur());

            } while (input != "");

        }
    }
}
