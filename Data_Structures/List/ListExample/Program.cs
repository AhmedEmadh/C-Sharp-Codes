using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{

    internal class Program
    {
        public static void Print(List<int> Numbers)
        {
            foreach (int number in Numbers)
            {
                Console.Write(number);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                numbers.Add(i);
            }

            Console.WriteLine("Count: " + numbers.Count);
            Console.WriteLine("Capacity: " + numbers.Capacity);

            numbers.AddRange(new List<int> { 9, 10, 11 });
            numbers.InsertRange(5, new List<int> { 6, 7, 8 });

            Print(numbers);
            numbers.Remove(11);
            numbers.RemoveAll(Numbers => Numbers % 2 == 0);
            Print(numbers);
            Console.ReadKey();

        }
    }
}
