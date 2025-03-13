using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateFunctionsInArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList { 1, 2, 3, 2, 4, 2, 5 };

            var minValue = arrayList.Cast<int>().Min();
            var maxValue = arrayList.Cast<int>().Max();
            var sum = arrayList.Cast<int>().Sum();
            var average = arrayList.Cast<int>().Average();
            var count = arrayList.Cast<int>().Count();

            Console.WriteLine("\nArrayList Items:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Minimum value in the ArrayList: " + minValue);
            Console.WriteLine("Maximum value in the ArrayList: " + maxValue);
            Console.WriteLine("Sum of values in the ArrayList: " + sum);
            Console.WriteLine("Average of values in the ArrayList: " + average);
            Console.WriteLine("Count of values in the ArrayList: " + count);

            arrayList.Sort();
            Console.WriteLine("\nArrayList Items after sorting:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
