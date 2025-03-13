using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();
            // Adding elements to the SortedDictionary
            sortedDictionary.Add("Apple", 10);
            sortedDictionary.Add("Banana", 20);
            sortedDictionary.Add("Cherry", 30);
            sortedDictionary["Orange"] = 15;


            // Displaying the contents of the sortedDictionary
            Console.WriteLine("Contents of the SortedDictionary:");
            foreach (var kvp in sortedDictionary)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            // Accessing values by key
            Console.WriteLine("\nAccessing values by key:");
            Console.WriteLine($"Value of 'apple': {sortedDictionary["Apple"]}");
            Console.WriteLine($"Value of 'banana': {sortedDictionary["Banana"]}");
            // Checking if a key exists
            Console.WriteLine("\nChecking if a key exists:");
            Console.WriteLine($"Contains key 'apple': {sortedDictionary.ContainsKey("Apple")}");

        }
    }
}
