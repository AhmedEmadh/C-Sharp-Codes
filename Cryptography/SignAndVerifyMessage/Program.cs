using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SignAndVerifyMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SignAndVerifyDataExample();
        }
        static string SignData(string message, string privateKey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privateKey);
                byte[] data = Encoding.UTF8.GetBytes(message);
                byte[] signature = rsa.SignData(data, CryptoConfig.MapNameToOID("SHA256"));
                return Convert.ToBase64String(signature);
            }
        }

        static bool VerifyData(string message, string signature, string publicKey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKey);
                byte[] data = Encoding.UTF8.GetBytes(message);
                byte[] signatureBytes = Convert.FromBase64String(signature);
                return rsa.VerifyData(data, CryptoConfig.MapNameToOID("SHA256"), signatureBytes);
            }
        }
        static void SignAndVerifyDataExample()
        {
            try
            {
                // Generate key pair
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    string publicKey = rsa.ToXmlString(false);
                    string privateKey = rsa.ToXmlString(true);

                    // Message to sign
                    string message = "This is a signed message.";

                    // Sign the data using the private key
                    string signature = SignData(message, privateKey);

                    // Verify the signature using the public key
                    bool isVerified = VerifyData(message, signature, publicKey);

                    // Display the results
                    Console.WriteLine($"\n\nMessage: {message}");
                    Console.WriteLine($"\nSignature: {signature}");
                    Console.WriteLine($"\nSignature Verified: {isVerified}");
                }
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine($"Signing/Verification error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
