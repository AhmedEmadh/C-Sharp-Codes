using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(string);
            Console.WriteLine(myType.Name);
            Console.WriteLine(myType.FullName);
            Console.WriteLine(myType.IsClass);
        }
    }
}
