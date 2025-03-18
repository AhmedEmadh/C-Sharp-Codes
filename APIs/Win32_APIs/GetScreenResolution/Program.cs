using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace GetScreenResolution
{
    internal class Program
    {
        [DllImport("user32.dll")]
        static extern int GetSystemMetrics(int nIndex);
        static void Main(string[] args)
        {
            int screenWidth = GetSystemMetrics(0);
            int screenHeight = GetSystemMetrics(1);
            Console.WriteLine("Screen Width: " + screenWidth);
            Console.WriteLine("Screen Height: " + screenHeight);
            Console.ReadKey();
        }
    }
}
