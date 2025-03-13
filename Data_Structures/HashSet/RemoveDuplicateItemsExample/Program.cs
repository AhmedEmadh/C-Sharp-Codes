using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateItemsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            HashSet<int> result = new HashSet<int>(arr);
            Console.WriteLine("After removing duplicate items:");
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
