using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplesExample
{
    internal class Program
    {
        static void Main()
        {
            // Declare a tuple
            (int, string, double) person = (1, "Alice", 5.5);


            // Access tuple elements
            Console.WriteLine("ID: " + person.Item1);
            Console.WriteLine("Name: " + person.Item2);
            Console.WriteLine("Height: " + person.Item3 + " feet");


            // Using a method that returns a tuple
            var values = GetValues();
            Console.WriteLine("Number: " + values.Item1);
            Console.WriteLine("Text: " + values.Item2);
            Console.ReadKey();
        }


        static (int, string) GetValues()
        {
            return (20, "Twenty");
        }
    }
}
