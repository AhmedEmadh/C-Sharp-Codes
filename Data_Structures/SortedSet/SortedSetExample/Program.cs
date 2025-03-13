using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSetExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> sortedSet = new SortedSet<int>();
            // Add elements to the SortedSet
            sortedSet.Add(5);
            sortedSet.Add(2);
            sortedSet.Add(8);
            sortedSet.Add(3);
            sortedSet.Add(3); // Duplicate element will not be added (It will be ignored)

            // Display the elements in the SortedSet
            Console.WriteLine("Elements in the SortedSet:");
            foreach (int i in sortedSet)
            {
                Console.WriteLine(i);
            }
            // Check if the SortedSet contains an element
            Console.WriteLine("Is 3 present in the SortedSet? " + sortedSet.Contains(3));
            // Remove an element from the SortedSet
            sortedSet.Remove(3);
            // Display the elements in the SortedSet
            Console.WriteLine("Elements in the SortedSet after removing 3:");
            foreach (int i in sortedSet)
            {
                Console.WriteLine(i);
            }
            // Clear all elements from the SortedSet
            sortedSet.Clear();
            Console.WriteLine("Number of elements in the SortedSet after clearing: " + sortedSet.Count);
            Console.ReadKey();
        }
    }
}
