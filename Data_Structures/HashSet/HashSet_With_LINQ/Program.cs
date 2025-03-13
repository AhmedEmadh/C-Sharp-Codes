using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_With_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>()
            {
                "John",
                "Doe",
                "Alice",
                "Bob",
                "Charlie",
                "David",
                "Eve",
                "Carol",
                "Frank",
            };
            var NamesStartsWithD = names.Where(name => name.StartsWith("D"));
            Console.WriteLine("Names:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\nNames Starts With D:");
            foreach (var name in NamesStartsWithD)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Names With Length More than 4:");
            var NamesWithLengthMoreThan4 = names.Where(name => name.Length > 4);
            foreach (var name in NamesWithLengthMoreThan4)
            {
                Console.WriteLine(name);
            }
        }
    }
}
