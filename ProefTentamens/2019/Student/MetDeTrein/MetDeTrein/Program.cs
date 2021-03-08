using System;
using TentamenFlex;

namespace MyLinkedListTester
{
    class Program
    {

        private static void Main(string[] args)
        {
            LinkedListStudent list = new LinkedListStudent();
            
            list.AddItem("Meppel");
            list.AddItem("Steenwijk");
            list.AddItem("Wolvega");
            list.AddItem("Heerenveen");
            list.AddItem("Akkrum");
            list.AddItem("Grou/Irnsum");
            list.AddItem("Leeuwarden");

            Console.WriteLine("07:36");
            list.ListStations();
            list.ListRetourRoute();
            
            Console.WriteLine("08:06");
            list.ListStations();
            list.ListRetourRoute();

            Console.WriteLine("08:36");
            list.ListStations();
            list.ListRetourRoute();
            
            Console.ReadLine();

        }// main
    }
}