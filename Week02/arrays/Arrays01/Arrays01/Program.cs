using System;
using System.Globalization;

namespace Arrays01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]    numbers = {1, 2, 3, 4, 5};
            string[] names   = {"Martin", "Jos", "Klaske"};
            float[]  reals   = { 1.2f, 1.3f, 1.4f };
            double[] dbls    = { 1.2, 1.3, 1.4 };

            int[] reeksObject = new int[15];

            string[,] matrix = new string[7, 5]; // 7 rijen (y), 5 kolommen (x)

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("{0} = {1}", i, numbers[i]);
            }
            
            foreach(var name in names) Console.WriteLine(name);
            names[2] = "Karel";
            foreach(var item in names) Console.WriteLine(item);
            
            // array object is immutable = niet veranderbaar: kan niet opnieuw in bulk geinitialiseerd worden 
            // dus onderstaande mag niet
            //numbers = {1,2,3,4,5,6,7,8};
            
            // individuele items veranderen mag wel
            numbers[2] = 12;
            
            // matrix vullen met (rij, kolom) waarden. 
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = "(" + c + "," + r + ")";
                }
            }
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c]);
                }

                Console.WriteLine();
            }
        }
    }
}
