﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace HashingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Data = "Hello World!";
            string HashedData = ComputeHash(Data);
            Console.WriteLine($"Original Data: {Data}");
            Console.WriteLine($"Hashed Data: {HashedData}");
            Console.WriteLine($"Hashed Data Length: {HashedData.Length}");
        }
        static string ComputeHash(string input)
        {
            //SHA is Secutred Hash Algorithm.
            // Create an instance of the SHA-256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));


                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
