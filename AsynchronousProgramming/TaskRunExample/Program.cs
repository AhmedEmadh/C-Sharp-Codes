using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRunExample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task task1 = Task.Run(() => DownloadFile("Download File 1"));
            Task task2 = Task.Run(() => DownloadFile("Download File 2"));

            await Task.WhenAll(task1, task2);

            Console.WriteLine("Task 1 and 2 completed");
            Console.ReadKey();

        }
        static void DownloadFile(string fileName)
        {
            Console.WriteLine($"Downloading {fileName}");
            Task.Delay(1000).Wait();
            Console.WriteLine($"Downloading {fileName} Completed");
        }
    }
}
