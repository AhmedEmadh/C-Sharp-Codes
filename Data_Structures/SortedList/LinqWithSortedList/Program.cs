using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedList = new SortedList<int, string>()
            {
                { 1, "One"},
                { 2, "Two" },
                { 3, "Three" },
                { 4, "Four" },
                { 5, "Five" }
            };
            var queryExpressionSyntax = from kvp in sortedList
                                        where kvp.Key > 1
                                        select kvp;
            Console.WriteLine("Query Expression Syntax Method:");
            foreach (var item in queryExpressionSyntax)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            // Query using Method Syntax
            var methodSyntax = sortedList.Where(kvp => kvp.Key > 1);
            Console.WriteLine("\nMethod Syntax:");
            foreach (var item in methodSyntax)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            // Filter key-value pairs with keys greater than a specific value
            int specificValue = 2;
            var filteredByKey = sortedList.Where(kvp => kvp.Key > specificValue);
            Console.WriteLine($"\nEntries with keys greater that {specificValue}:");
            foreach (var item in filteredByKey)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.ReadKey();
        }
    }
}
