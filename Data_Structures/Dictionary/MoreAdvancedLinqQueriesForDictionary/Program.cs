using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAdvancedLinqQueriesForDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> fruitsCategory = new Dictionary<string, string>()
            {
                {"Apple","Tree" },
                {"Banana", "Herb"},
                {"Cheery", "Tree" },
                {"Strawberry", "Bush" },
                {"Raspberry", "Bush" }

            };
            // Grouping fruits by category
            var groupedFruits = fruitsCategory.GroupBy(kvp => kvp.Value);
            foreach (var group in groupedFruits)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item.Key}");
                }
            }
            // Combined LINQ queries
            Dictionary<string, int> fruitBasket = new Dictionary<string, int>()
            {
                {"Apple", 5 },
                {"Banana", 10 },
                {"Cheery", 15 },
                {"Strawberry", 20 },
                {"Raspberry", 25 }
            };
            var sortedFilteredFruits = fruitBasket
                .Where(kvp => kvp.Value > 10)
                .OrderBy(kvp => kvp.Value)
                .Select(kvp => new { kvp.Key, kvp.Value });
            Console.WriteLine("Sorted and Filtered Fruits:");
            foreach (var item in sortedFilteredFruits)
            {
                Console.WriteLine($"\t Fruit: {item.Key}, Quantitny: {item.Value}");
            }
        }
    }
}
