using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("Hello");
            list.Add(true);
            list.Add(15.5);
            Console.WriteLine("Elements in ArrayList:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Remove(15.5);

            Console.WriteLine("\nAfter removing and element:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
