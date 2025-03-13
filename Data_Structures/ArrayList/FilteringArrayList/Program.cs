using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // we use cast to convert it to int first
            var evenNumbers = arrayList.Cast<int>().Where(num => num % 2 == 0);

            Console.WriteLine("Even numbers in the list are: ");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
