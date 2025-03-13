using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6, 7 };
            HashSet<int> set3 = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> set4 = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7 };

            // SetEquals
            Console.WriteLine("SetEquals:");
            Console.WriteLine(set1.SetEquals(set2)); // False
            Console.WriteLine(set1.SetEquals(set3)); // True

            // IsSubsetOf
            Console.WriteLine("\nIsSubsetOf:");
            Console.WriteLine(set1.IsSubsetOf(set2)); // False
            Console.WriteLine(set1.IsSubsetOf(set3)); // True

            // IsSupersetOf
            Console.WriteLine("\nIsSupersetOf:");
            Console.WriteLine(set1.IsSupersetOf(set2)); // False
            Console.WriteLine(set4.IsSupersetOf(set1)); // True

            // Overlaps
            Console.WriteLine("\nOverlaps:");
            Console.WriteLine(set1.Overlaps(set2)); // True
            Console.WriteLine(set1.Overlaps(set4)); // True

        }
    }
}
