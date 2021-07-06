using System;
using TentamenFlexHerkansing;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRestaurantList visitors = new MyRestaurantList();

            visitors.AddItem("12:00:00", 1);
            visitors.AddItem("12:10:00", 2);
            visitors.AddItem("12:20:00", 3);
            visitors.AddItem("12:30:00", -3);
            visitors.AddItem("12:40:00", 8);
            visitors.AddItem("12:41:00", 2);
            visitors.AddItem("12:43:00", 3);
            visitors.AddItem("12:45:00", 3);
            visitors.AddItem("13:00:00", -2);
            visitors.AddItem("13:10:00", -8);
            visitors.AddItem("13:20:00", -3);

            visitors.showVisitorChanges();

            Console.WriteLine("De grootste groep was: {0} mensen", visitors.GetLargestGroup());
        }
    }
}
