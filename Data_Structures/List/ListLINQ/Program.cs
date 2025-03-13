using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLINQ
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
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"The List is {{{string.Join(",",list)}}}");
            //LINQ
            Console.WriteLine("The Sum Of The List is " + list.Sum());
            Console.WriteLine("The Average Of The List is " + list.Average());
            Console.WriteLine("The Maximum Of The List is " + list.Max());
            Console.WriteLine("The Minimum Of The List is " + list.Min());
            Console.WriteLine("The Count Of The List is " + list.Count());

            //Filtering
            Console.WriteLine("The Even Numbers Are: {" + string.Join(",", list.Where(n => n % 2 == 0))+"}");
            Console.WriteLine("The Odd Numbers Are: {" + string.Join(",", list.Where(n => n % 2 != 0))+"}");
            Console.WriteLine("The Numbers Greater Than 5 Are: {" + string.Join(",", list.Where(n => n > 5)) + "}");
            Console.WriteLine("The Numbers Less Than 5 Are: {" + string.Join(",", list.Where(n => n < 5)) + "}");
            //Sorting
            Console.WriteLine("The List In Ascending Order: {" + string.Join(",", list.OrderBy(n => n)) + "}");
            Console.WriteLine("The List In Descending Order: {" + string.Join(",", list.OrderByDescending(n => n)) + "}");
            //Also Sorting
            list.Sort();
            list.Reverse();
            //Using Contains
            Console.WriteLine("Is List Contains 5: " + list.Contains(5));
            //Using Exists
            Console.WriteLine("Is List Contains 5: " + list.Exists(n => n == 5));
            //Using Find
            Console.WriteLine("The First Number Greater Than 5: " + list.Find(n => n > 5));
            //Using FindAll
            Console.WriteLine("The Numbers Greater Than 5: {" + string.Join(",", list.FindAll(n => n > 5)) + "}");
            //Using Any
            Console.WriteLine("Is Any Number Greater Than 5: " + list.Any(n => n > 5));

        }
    }
}
