using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace SecretSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                byte[] hashValue = mySHA256.ComputeHash(Encoding.UTF8.GetBytes("ghghdhdfhdfh"));
                PrintByteArray(hashValue);
            }
        }

        // Display the byte array in a readable format.
        public static void PrintByteArray(byte[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]:x2}");
            }
            Console.WriteLine();
        }
    }
}
