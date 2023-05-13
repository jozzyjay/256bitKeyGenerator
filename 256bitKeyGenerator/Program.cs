using System;
using System.Security.Cryptography;

namespace RandomKeyGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomKey = GenerateRandomKey(256);
            Console.WriteLine("Random Key: " + randomKey);
        }

        static string GenerateRandomKey(int keySizeInBits)
        {
            byte[] key = new byte[keySizeInBits / 8];

            using (var rngProvider = new RNGCryptoServiceProvider())
            {
                rngProvider.GetBytes(key);
            }

            return Convert.ToBase64String(key);
        }
    }
}