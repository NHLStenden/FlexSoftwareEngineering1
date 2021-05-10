using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionOverloading
{
    class SmartFunctions
    {

        public static int Add()
        {
            // hiermee implementeer je dus 2 default waarden voor de basisfunctie Add(int,int)
            return Add(0, 0);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            // return a + b + c;

            return Add( Add(a, b), c );
        }

        public static int Add(int[] list)
        {
            int result = Add();
            foreach (int item in list)
            {
                result = Add(result, item);
            }
            return result;
        }

        public static int Sum(params int[] list)
        {
            int result = 0;
            foreach (int item in list)
            {
                result += item;
            }
            return result;
        }
        
        public static double Sum(params double[] list)
        {
            double result = 0;
            foreach (double item in list)
            {
                result += item;
            }
            return result;
        }

        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static float Add(float a, int b)
        {
            return a + (b * 1.0f);
        }

/*        DIT MAG DUS NIET!
 *        public static float Add(int a, int b)
        {
            return (float)a + b;
        }*/

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static string Add(string prefix, int a, int b)
        {
            return prefix + (a + b);
        }

        public static string Add(string prefix, string suffix, params int[] list)
        {
            double result = 0;
            foreach (double item in list)
            {
                result += item;
            }
            return prefix + result + suffix;
        }


    }
}
