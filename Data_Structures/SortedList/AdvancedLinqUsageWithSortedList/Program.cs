using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLinqUsageWithSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedList = new SortedList<int, string>()
            {
                {1, "Apple" },
                {2, "Banana" },
                {3, "Cherry" },
                {4, "Date" },
                {5, "Grape" },
                {6, "Fig" },
                {7 , "Elderberry" }
            };
            // Grouping by the length of the value
            var groupedByLength = sortedList.GroupBy(kvp => kvp.Value.Length);
            foreach (var group in groupedByLength)
            {
                Console.WriteLine($"Grouped by length: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item.Key} - {item.Value}");
                }
            }

        }
    }
}
