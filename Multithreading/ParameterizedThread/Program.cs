using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParameterizedThread
{
    internal class Program

    {
        static void Main(string[] args)
        {
            // Note that your program is the main thread.


            // Create a new thread and start it
            Thread t1 = new Thread(() => ThreadMethod("ThreadMethod1"));
            Thread t2 = new Thread(() => ThreadMethod("ThreadMethod2"));
            t1.Start();
            t2.Start();

            t2.Join();

            // Main thread continues its execution
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Main Thread: " + i);
                Thread.Sleep(1000); // Sleep for 1 second
            }
            Console.ReadKey();
        }
        static void ThreadMethod(string name)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{name}: " + i);
                Thread.Sleep(1000);
            }
        }
        
    }
}
