using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6, 7 };


            HashSet<int> union = new HashSet<int>(set1);
            HashSet<int> intersection = new HashSet<int>(set1);
            HashSet<int> difference = new HashSet<int>(set1);
            HashSet<int> symmetricDifference = new HashSet<int>(set1);
            // Union
            union.UnionWith(set2);
            // Intersection
            intersection.IntersectWith(set2);
            // Difference
            difference.ExceptWith(set2);
            // Symmetric Difference
            symmetricDifference.SymmetricExceptWith(set2);
            //Print
            Console.WriteLine("Set1:");
            PrintHashSet(set1);
            Console.WriteLine("Set2:");
            PrintHashSet(set2);

            Console.WriteLine("Union:");
            PrintHashSet(union);
            Console.WriteLine("Intersection:");
            PrintHashSet(intersection);
            Console.WriteLine("Difference:");
            PrintHashSet(difference);
            Console.WriteLine("Symmetric Difference:");
            PrintHashSet(symmetricDifference);

        }
        static void PrintHashSet(HashSet<int> HashSet)
        {
            foreach (int i in HashSet)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
        }
    }
}
