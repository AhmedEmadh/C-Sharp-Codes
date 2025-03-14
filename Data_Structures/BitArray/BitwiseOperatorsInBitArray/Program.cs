using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperatorsInBitArray
{
    internal class Program
    {
        static string BitArrayToString(BitArray bits)
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

            BitArray bitArray1 = new BitArray(new bool[] { true, false, true, false });
            BitArray bitArray2 = new BitArray(new bool[] { true, true, false, false });
            BitArray bitArray3 = new BitArray(new bool[] { false, false, true, true });
            BitArray bitArray4 = new BitArray(new bool[] { true, true, true, true });
            // Bitwise AND
            BitArray result = bitArray1.And(bitArray2);
            Console.WriteLine("\nBitwise AND of bitArray1 and bitArray2:");
            Console.WriteLine(BitArrayToString(bitArray1));
            Console.WriteLine(BitArrayToString(bitArray2));
            Console.WriteLine("-------------------------");
            foreach (bool bit in result)
            {
                Console.Write(bit ? "1" : "0");
            }
            Console.WriteLine();
            // Bitwise OR
            result = bitArray1.Or(bitArray2);
            Console.WriteLine("\nBitwise OR of bitArray1 and bitArray2:");
            Console.WriteLine(BitArrayToString(bitArray1));
            Console.WriteLine(BitArrayToString(bitArray2));
            Console.WriteLine("-------------------------");
            foreach (bool bit in result)
            {
                Console.Write(bit ? "1" : "0");
            }
            Console.WriteLine();
            // Bitwise XOR
            result = bitArray1.Xor(bitArray2);
            Console.WriteLine("\nBitwise XOR of bitArray1 and bitArray2:");
            Console.WriteLine(BitArrayToString(bitArray1));
            Console.WriteLine(BitArrayToString(bitArray2));
            Console.WriteLine("-------------------------");
            foreach (bool bit in result)
            {
                Console.Write(bit ? "1" : "0");
            }
            Console.WriteLine();
            // Bitwise NOT
            result = bitArray3.Not();
            Console.WriteLine("\nBitwise NOT of bitArray3:");
            Console.WriteLine(BitArrayToString(bitArray3));
            Console.WriteLine("-------------------------");
            foreach (bool bit in result)
            {
                Console.Write(bit ? "1" : "0");
            }
            Console.WriteLine();
            // Bitwise AND
            result = bitArray1.And(bitArray4);
            Console.WriteLine("\nBitwise AND of bitArray1 and bitArray4:");
            Console.WriteLine(BitArrayToString(bitArray1));
            Console.WriteLine(BitArrayToString(bitArray4));
            Console.WriteLine("-------------------------");
            foreach (bool bit in result)
            {
                Console.Write(bit ? "1" : "0");
            }
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
