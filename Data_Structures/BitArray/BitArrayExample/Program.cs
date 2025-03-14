using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrayExample
{
    internal class Program
    {
        static string BitArrayToStringUsingBuilder(BitArray bits)
        {
            StringBuilder sb = new StringBuilder(bits.Length);
            for (int i = 0; i < bits.Length; i++)
            {
                sb.Append(bits[i] ? 1 : 0);
            }
            return sb.ToString();
        }
        static string BitArrayToStringUsingChar(BitArray bits)
        {
            char[] chars = new char[bits.Length];
            for (int i = 0; i < bits.Length; i++)
            {
                chars[i] = bits[i] ? '1' : '0';
            }
            return new string(chars);
        }
        static void Main(string[] args)
        {
            BitArray bits1 = new BitArray(10);
            
            Console.WriteLine("\nbits1 content: " + BitArrayToStringUsingChar(bits1));
            for (int i = 0; i < bits1.Count; i++)
            {
                bool bit = bits1[i];
                Console.WriteLine("Bit at index " + i + " is " + (bit));
            }
            //Create bit array from Array of booleans
            bool[] bools = { true, false, true, true, false, true, true, true, false, false };
            BitArray bits2 = new BitArray(bools);
            Console.WriteLine("\nbits2 content: " + BitArrayToStringUsingBuilder(bits2));
            for (int i = 0; i < bits2.Count; i++)
            {
                bool bit = bits2[i];
                Console.WriteLine("Bit at index " + i + " is " + (bit));
            }
            //Create bit array from byte array
            byte[] bytes = { 1, 2, 3, 4, 5 };
            BitArray bits3 = new BitArray(bytes);
            Console.WriteLine("\nbits3 content: " + BitArrayToStringUsingChar(bits3));
            for (int i = 0; i < bits3.Count; i++)
            {
                bool bit = bits3[i];
                Console.WriteLine("Bit at index " + i + " is " + (bit));
            }
            //Basic operations
            BitArray bits4 = new BitArray(10);
            bits4.Set(2,true);
            bits4.Set(5, true);
            bits4[7] = true;
            bits4[8] = false;
            Console.WriteLine("\nbits4 content: " + BitArrayToStringUsingBuilder(bits4));
            for (int i = 0; i < bits4.Count; i++)
            {
                bool bit = bits4[i];
                Console.WriteLine("Bit at index " + i + " is " + (bit));
            }
            //All bits are set to true
            bits4.SetAll(true);
            Console.WriteLine("\nbits4 content: " + BitArrayToStringUsingChar(bits4));
            for (int i = 0; i < bits4.Count; i++)
            {
                bool bit = bits4[i];
                Console.WriteLine("Bit at index " + i + " is " + (bit));
            }

        }
    }
}
