using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string,int> sortedList = new SortedList<string, int>();
            sortedList.Add("Banana", 2);
            sortedList.Add("Orange", 3);
            sortedList.Add("Apple", 3);

            Console.WriteLine($"The Quantity of Apple is {sortedList["Apple"]}");

            // Itereate through the sorted list
            Console.WriteLine("Iterating through the elements of the sorted list");
            foreach (var item in sortedList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
        }
    }
}
