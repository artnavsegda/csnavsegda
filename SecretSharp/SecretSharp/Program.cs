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
                String secret = "53Cr3t";
                String guid = "936DE051-3022-4217-834B-F5BDBFDBEE3A";
                String version = "4.0.9";
                String dayOfMouth = "10";

                String clearString = secret + ':' + guid + ':' + version + ':' + dayOfMouth;
                Console.WriteLine("Clear value: " + clearString);

                byte[] hashValue = mySHA256.ComputeHash(Encoding.UTF8.GetBytes(clearString));

                Console.Write("Hashed value: ");
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
