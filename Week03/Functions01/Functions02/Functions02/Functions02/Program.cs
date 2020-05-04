using System;

namespace Functions02
{
    class Program
    {

        static int someGlobalVariable;
        static void Main(string[] args)
        {
            Console.WriteLine(AddStrings("Hello", "World!"));
            Console.WriteLine(AddStrings("Hello", " ", "World!"));
            Console.WriteLine(AddStrings(new string[] { "Hello", "Everybody", "Tonight" }));

            someGlobalVariable = 10;
            int result = UglyFunction();

            Console.WriteLine("Result = {0}", someGlobalVariable);
            Console.WriteLine("someGlobalVariable = {0}", someGlobalVariable);

            Console.WriteLine(SomeGenericFunction<int>(1234,5678));
            Console.WriteLine(SomeGenericFunction<double>(3.0, 4.567));
            Console.WriteLine(SomeGenericFunction(3.9, 4.567)); // infer float
        }

        static string AddStrings(string s1, string s2)
        {
            return s1 + s2;
        }

        static string AddStrings(string s1, string s2, string s3)
        {
            return s1 + s2 + s3;
        }

        static string AddStrings(string[] strings)
        {
            string result = "";

            // TODO: make better for-loop to prevent last space 
            // (SEE https://docs.microsoft.com/en-us/visualstudio/ide/using-the-task-list?view=vs-2019)
            // to view the TODO-list, select in Visual Studio from the menu --> View -->Task list 
            foreach (var s in strings)
            {
                result += s + " ";
            }

            return result.Trim(); // trim result to remove last space (ugly)
        }

        /// <summary>
        /// Returns the value of someGlobalVariable increased by one.
        /// </summary>
        /// <remarks>Ugly side effects: also changes the value of someGlovalVariable</remarks>
        /// <returns></returns>
        static int UglyFunction()
        {
            someGlobalVariable++;
            return someGlobalVariable;
        }

        /// <summary>
        /// Advanced function using Generics. Concats two items as strings.
        /// </summary>
        /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/"/>
        /// <typeparam name="T"></typeparam>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static string SomeGenericFunction<T>(T a, T b)
        {
            return a.ToString() + b.ToString();
        }
    }
}
