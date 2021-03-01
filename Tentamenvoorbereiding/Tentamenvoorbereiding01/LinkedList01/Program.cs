using System;

namespace LinkedList01
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStudent list = new LinkedListStudent();
            list.AddItem("abc");
            list.AddItem("def");
            list.AddItem("ghi");
            list.AddItem("jkl");
            list.AddItem("mno");
            Console.WriteLine("--------1--------------------");
            list.ListItems();
            list.ListItems();
            list.ListItems();
            list.ListItems();
            list.ListItems();
            Console.WriteLine("--------2--------------------");
            list.ListItemsForward();
            list.ListItemsForward();
            list.ListItemsForward();
            list.ListItemsForward();
            Console.WriteLine("---------3-------------------");
            
            list.ListItemsFout();
            list.ListItemsFout();
            list.ListItems();
            Console.WriteLine("----------4------------------");

            //list.ListItemsReverse();
            //list.ListItemsForward();
            //Console.WriteLine("----------------------------");

        }
    }
}
